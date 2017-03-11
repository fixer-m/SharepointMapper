using System;

namespace Shmapper
{
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
    }
}