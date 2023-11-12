using System.Diagnostics.Contracts;
using Unity.Burst;
using Unity.Collections;
using UntitledTD.Utils.Monads;

namespace UntitledTD.Utils.Errors
{
    [BurstCompile]
    public static class ErrorFactory
    {
        [BurstCompile]
        [Pure]
        public static Error NotImplemented(Maybe<FixedString4096Bytes> details)
        {
            return new Error { Code = ErrorCode.NotImplemented, Message = "Not implemented", Details = details };
        }
    }
}