using System;

namespace IB.CSharpApiClient.Exceptions
{
    public class IBException : Exception
    {
        public int ErrorCode { get; }

        public IBException(string message): base(message) { }

        public IBException(string message, int errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(ErrorCode)}: {ErrorCode}";
        }
    }
}