using Rocket.API;
using Rocket.Core.Commands;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using SolokLibrary.Database.MySQL;
using SolokLibrary.ExamplePlugin1;
using SolokLibrary.Player;

namespace SolokLibrary.ExamplePlugin2
{
    public class Main : RocketPlugin<Configuration>
    {
        protected override void Load()
        {
            U.Events.OnPlayerConnected += Events_OnPlayerConnected;
            U.Events.OnPlayerDisconnected += Events_OnPlayerDisconnected;
        }
        protected override void Unload()
        {
            U.Events.OnPlayerConnected -= Events_OnPlayerConnected;
            U.Events.OnPlayerDisconnected -= Events_OnPlayerDisconnected;
        }

        private static void Events_OnPlayerDisconnected(Rocket.Unturned.Player.UnturnedPlayer player)
        {
            var sPlayer = new SPlayer(player);
            DatabaseManager.SetupMySql("localhost", "test", "utf8", "root", "", "MySQL Opened.");
            DatabaseManager.DeleteData("InGamePlayers", sPlayer.ID, "steamIds");
        }

        private static void Events_OnPlayerConnected(Rocket.Unturned.Player.UnturnedPlayer player)
        {
            var sPlayer = new SPlayer(player);
            DatabaseManager.SetupMySql("localhost", "test", "utf8", "root", "", "MySQL Opened.");
            DatabaseManager.InsertData("InGamePlayers", sPlayer.ID, "steamIds");
        }

        [RocketCommand("control", "control command", "/control <id>", AllowedCaller.Player)]
        public void Example(IRocketPlayer caller, string[] parameters)
        {
            var id = parameters[0];
            UnturnedChat.Say(caller,
                DatabaseManager.DatabaseHaveData("InGamePlayers", id, "steamIds")
                    ? "MySQL have this steamId"
                    : "MySQL haven't this steamId");
        }
    }
}