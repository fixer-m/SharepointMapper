using System;
using System.Runtime.Serialization;

namespace Shmapper
{
    [Serializable]
    internal class InvalidMappingExeption : Exception
    {
        public InvalidMappingExeption()
        {
        }

        public InvalidMappingExeption(string message) : base(message)
        {
        }

        public InvalidMappingExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidMappingExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}