using Mobile.App.Exceptions;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.App.Services.RequestWarpper
{
    public static class MakeRequest
    {
        private static HttpClient Client { get; } = new HttpClient();
        static MakeRequest()
        {
            Client.Timeout = TimeSpan.FromSeconds(60);
        }

        public static async Task<TOutput> GetAsync<TOutput>(Uri uri)
        {
            using (var request = ConfigureHttpRequestMessage(new HttpRequestMessage(HttpMethod.Get, uri)))
            {
                using (var response = await Client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    if (!response.IsSuccessStatusCode)
                    {
                        HandleResponse(response, responseBody);
                    }
                    return JsonConvert.DeserializeObject<TOutput>(responseBody);
                }
            }
        }

        public static async Task<TOutput> PostAsync<TOutput, TInput>(Uri uri, TInput data)
        {
            using (var request = ConfigureHttpRequestMessage(new HttpRequestMessage(HttpMethod.Post, uri)))
            {
                var json = JsonConvert.SerializeObject(data);
                using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
                {
                    request.Content = stringContent;
                    using (var response = await Client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                    {
                        string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        if (!response.IsSuccessStatusCode)
                        {
                            HandleResponse(response, responseBody);
                        }
                        return JsonConvert.DeserializeObject<TOutput>(responseBody);
                    }
                }
            }
        }

        private readonly static int BufferSize = 4096;
        public static async Task<string> DownloadFileAsync(Uri uri, string filePath)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromMinutes(5);
                    using (var request = ConfigureHttpRequestMessage(new HttpRequestMessage(HttpMethod.Get, uri)))
                    using (var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                    {
                        if (!response.IsSuccessStatusCode)
                        {
                            HandleResponse(response);
                        }
                        long totalData = response.Content.Headers.ContentLength.GetValueOrDefault(-1L);
                        using (var fileStream = OpenStream(filePath))
                        {
                            using (var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                            {
                                var totalRead = 0L;
                                var buffer = new byte[BufferSize];
                                var isMoreDataToRead = true;
                                do
                                {
                                    var read = await stream.ReadAsync(buffer, 0, buffer.Length).ConfigureAwait(false);
                                    if (read == 0)
                                    {
                                        isMoreDataToRead = false;
                                    }
                                    else
                                    {
                                        await fileStream.WriteAsync(buffer, 0, read).ConfigureAwait(false);
                                        totalRead += read;
                                    }
                                } while (isMoreDataToRead);
                                return filePath;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static Stream OpenStream(string path)
        {
            return new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, BufferSize);
        }

        public static void FireAndForgetPostAsync<TInput>(Uri uri, TInput data)
        {

#pragma warning disable 4014
            Task.Run(async () =>
            {
                try
                {
                    using (var request = ConfigureHttpRequestMessage(new HttpRequestMessage(HttpMethod.Post, uri)))
                    {
                        var json = JsonConvert.SerializeObject(data);
                        using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
                        {
                            request.Content = stringContent;
                            var response = await Client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
                            response.Dispose();
                        }
                    }
                }
                catch (Exception)
                {
                }
            }).ConfigureAwait(false);
#pragma warning restore 4014
        }

        private static HttpRequestMessage ConfigureHttpRequestMessage(HttpRequestMessage request)
        {
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
            //request.Headers.Add("x-api-key", GlobalSetting.Instance.Api_Key);
            //request.Headers.Add("SessionId", GlobalSetting.Instance.SessionId);
            //request.Headers.Add("MACAddress", GlobalSetting.Instance.MacAddress);
            //request.Headers.Add("User-Agent", GlobalSetting.Instance.UserAgent);
            return request;
        }

        private static TOutput DeserializeJsonFromStream<TOutput>(Stream stream)
        {
            if (stream == null || stream.CanRead == false)
            {
                return default;
            }

            using (var streamReader = new StreamReader(stream))
            using (var jsonTextReader = new JsonTextReader(streamReader))
            {
                var jsonSerializer = new JsonSerializer();
                var result = jsonSerializer.Deserialize<TOutput>(jsonTextReader);
                return result;
            }
        }

        private static async Task<string> StreamToStringAsync(Stream stream)
        {
            string content = null;
            if (stream != null)
            {
                using (var streamReader = new StreamReader(stream))
                {
                    content = await streamReader.ReadToEndAsync();
                }
            }
            return content;
        }

        private static void HandleResponse(HttpResponseMessage response, string content = null)
        {
            /*bool dispose = false;
            if (stream == null)
            {
                dispose = true;
                stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            }*/

            try
            {
                //var content = await StreamToStringAsync(stream).ConfigureAwait(false);
                int statusCode = (int)response.StatusCode;

                if (response.StatusCode == HttpStatusCode.Forbidden || response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    throw new ServiceErrorException(statusCode, "No se puede acceder al servicio.");
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest || statusCode == 590)
                {
                    var apiError = JsonConvert.DeserializeObject<ApiErrorException>(content);
                    throw new ServiceErrorException(statusCode, apiError.Mensaje);
                }
                else if (statusCode == 589)
                {
                    var apiError = JsonConvert.DeserializeObject<ApiErrorException>(content);

                    string resultado = apiError.Mensaje.Substring(
                        apiError.Mensaje.IndexOf("[") + 1,
                        apiError.Mensaje.Length - apiError.Mensaje.IndexOf("[") - 1
                    );

                    string resultado2 = resultado.Substring(
                        resultado.IndexOf("[") + 1,
                        resultado.Length - resultado.IndexOf("[") - 1
                    );

                    throw new ServiceErrorException(statusCode, resultado2.TrimEnd(']'));
                }
                else if (response.StatusCode == HttpStatusCode.InternalServerError)
                {
                    var backendError = JsonConvert.DeserializeObject<BackendErrorException>(content);
                    throw new ServiceErrorException(statusCode, backendError.Error);
                }
                else
                {
                    throw new ServiceErrorException(statusCode, "Se ha producido un error inesperado.");
                }

                throw new HttpRequestException(content);
            }
            catch (Exception)
            {
                throw;
            }
            /*finally
            {
                if (dispose)
                {
                    stream.Dispose();
                }
            }*/
        }
    }
}