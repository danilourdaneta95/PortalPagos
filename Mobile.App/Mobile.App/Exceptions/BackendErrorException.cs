using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.App.Exceptions
{
    public class BackendErrorException
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("mensaje")]
        public string Mensaje { get; set; }
    }
}
