using Unity.Burst;

namespace UntitledTD.Utils.Errors
{
    [BurstCompile]
    public readonly struct Error
    {
        public ErrorCode Code { get; init; }
        public string Message { get; init; }
    }
}