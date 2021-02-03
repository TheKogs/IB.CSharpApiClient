namespace IB.CSharpApiClient.Exceptions
{
    public class ScannerException : IBException
    {
        public ScannerException(string message) : base(message) { }

        public ScannerException(string message, int errorCode) : base(message, errorCode) { }
    }
}