using System;
using System.Runtime.Serialization;

namespace Mobile.App.Services.RequestWarpper
{
    [Serializable]
    internal class ServiceErrorException : Exception
    {
        private int statusCode;
        private string v;

        public ServiceErrorException()
        {
        }

        public ServiceErrorException(string message) : base(message)
        {
        }

        public ServiceErrorException(int statusCode, string v)
        {
            this.statusCode = statusCode;
            this.v = v;
        }

        public ServiceErrorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ServiceErrorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}