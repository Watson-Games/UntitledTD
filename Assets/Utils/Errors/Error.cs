using Unity.Burst;
using Unity.Collections;
using UntitledTD.Utils.Monads;

namespace UntitledTD.Utils.Errors
{
    [BurstCompile]
    public readonly struct Error
    {
        public ErrorCode Code { get; init; }
        public FixedString512Bytes Message { get; init; }
        public Maybe<FixedString4096Bytes> Details { get; init; }
    }
}