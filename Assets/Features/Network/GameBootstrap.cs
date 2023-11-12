using Unity.NetCode;
using UnityEngine.Scripting;

namespace UntitledTD.Features.Network
{
    [Preserve]
    public class GameBootstrap : ClientServerBootstrap
    {
        public override bool Initialize(string defaultWorldName)
        {
            AutoConnectPort = 5051;
            return base.Initialize(defaultWorldName);
        }
    }
}