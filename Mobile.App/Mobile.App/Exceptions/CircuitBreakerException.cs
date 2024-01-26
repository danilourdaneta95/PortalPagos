using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Mobile.App.Exceptions
{
    [System.SerializableAttribute]
    public class CircuitBreakerException : Exception
    {
        public int Code { get; }
        public string CodeMessage { get; }

        public CircuitBreakerException()
        {
        }

        protected CircuitBreakerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
