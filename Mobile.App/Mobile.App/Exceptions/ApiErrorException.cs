using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.App.Exceptions
{
    public class ApiErrorException
    {
        [JsonProperty("code")]
        public string Codigo { get; set; }

        [JsonProperty("message")]
        public string Mensaje { get; set; }
    }
}
