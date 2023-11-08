namespace UntitledTD.Utils.Errors
{
    public static class ErrorFactory
    {
        public static Error NotImplemented(string message)
        {
            return new Error { Code = ErrorCode.NotImplemented, Message = message };
        }
    }
}