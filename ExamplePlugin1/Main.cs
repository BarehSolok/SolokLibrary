using Rocket.Core.Plugins;
using Rocket.Unturned;
using SolokLibrary.Player;

namespace SolokLibrary.ExamplePlugin1
{
    public class Main : RocketPlugin<Configuration>
    {
        protected override void Load()
        {
            U.Events.OnPlayerConnected += Events_OnPlayerConnected;
        }

        private static void Events_OnPlayerConnected(Rocket.Unturned.Player.UnturnedPlayer player)
        {
            var sPlayer = new SPlayer(player);
            if (sPlayer.HasGroup("Prisoner"))
            {
                sPlayer.ArrestPlayer();
            }
        }
    }
}