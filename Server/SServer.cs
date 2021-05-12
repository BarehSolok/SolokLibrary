using SDG.Unturned;
using SolokLibrary.Server.Classes;

namespace SolokLibrary.Server
{
    public static class SServer
    {
        // PROPS
        public static string ID() => Provider.serverID;
        public static uint IP() => Provider.ip;
        public static string Map() => Provider.map;
        public static string Name() => Provider.serverName;
        public static int PlayerCount() => Provider.clients.Count;
        public static int PlayerMaxPlayers() => Provider.maxPlayers;
        public static string ServerPassword() => Provider.serverPassword;
        public static ushort ServerPort() => Provider.port;
        
        // SUB-CLASSES
        public static UIClass UIManager => new UIClass();
        public static VehicleClass VehicleManager => new VehicleClass();
    }
}