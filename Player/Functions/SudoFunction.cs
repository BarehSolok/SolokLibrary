using Rocket.Unturned.Player;
using SDG.Unturned;
using UnityEngine;

namespace SolokLibrary.Player.Functions
{
    public static class SudoFunction
    {
        public static void Sudo(UnturnedPlayer player, string text) => ChatManager.serverSendMessage(text, Color.green, player.SteamPlayer(), null, EChatMode.SAY, null, true);
    }
}
