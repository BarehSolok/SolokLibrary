using Rocket.Unturned.Player;
using SDG.Unturned;

namespace AtomicLibrary.Player.Funcs
{
    public class Sudo
    {
        public void sudo(UnturnedPlayer player, string text) => ChatManager.instance.askChat(player.CSteamID, (byte)EChatMode.SAY, text);
    }
}
