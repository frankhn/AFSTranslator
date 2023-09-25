using System;

namespace AfsTranslator.src.Utils
{
    class CustomException : Exception
    {
        public CustomException(string message)
        {
        }
        private static void customException(string message) => throw new CustomException("Custom exception in TestThrow()");
    }
}
