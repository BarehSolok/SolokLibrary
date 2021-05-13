using System;
using Rocket.API;
using Rocket.Core.Commands;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using SolokLibrary.Database.MySQL;
using SolokLibrary.Logger;
using SolokLibrary.Player;

namespace SolokLibrary.ExamplePlugin3
{
    public class Main : RocketPlugin<Configuration>
    {
        internal DatabaseManagerV2 DB;
        
        protected override void Load()
        {
            InitializeMySqlDatabase();
            
            // EVENTS
            U.Events.OnPlayerConnected += Events_OnPlayerConnected;
            U.Events.OnPlayerDisconnected += Events_OnPlayerDisconnected;
        }
        protected override void Unload()
        {
            DB = null;
            
            // EVENTS
            U.Events.OnPlayerConnected -= Events_OnPlayerConnected;
            U.Events.OnPlayerDisconnected -= Events_OnPlayerDisconnected;
        }

        private void Events_OnPlayerDisconnected(Rocket.Unturned.Player.UnturnedPlayer player)
        {
            var sPlayer = new SPlayer(player);
            DB.DeleteData("exampleplugin3", sPlayer.ID, "SteamID");
        }
        private void Events_OnPlayerConnected(Rocket.Unturned.Player.UnturnedPlayer player)
        {
            var sPlayer = new SPlayer(player);
            DB.InsertData("exampleplugin3", sPlayer.ID, "SteamID");
        }

        [RocketCommand("control", "control command", "/control <id>", AllowedCaller.Player)]
        public void Example(IRocketPlayer caller, string[] parameters)
        {
            var id = parameters[0];
            UnturnedChat.Say(caller,
                DB.IsDataExist("exampleplugin3", id, "SteamID")
                    ? "MySQL have this steamId"
                    : "MySQL haven't this steamId");
        }
        
        private void InitializeMySqlDatabase()
        {
            try
            {
                DB = new DatabaseManagerV2(Configuration.Instance.DatabaseAddress, Configuration.Instance.DatabasePort,
                    Configuration.Instance.DatabaseUsername, Configuration.Instance.DatabasePassword,
                    Configuration.Instance.DatabaseName, Configuration.Instance.DatabaseTableName,
                    Configuration.Instance.DatabaseCreateTableQuery);
            }
            catch (Exception ex)
            {
                SLogger.Exception(ex);
                Unload();
            }
        }
    }
}