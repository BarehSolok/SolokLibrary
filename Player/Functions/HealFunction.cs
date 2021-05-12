using Rocket.Unturned.Player;

namespace SolokLibrary.Player.Functions
{
    public static class HealFunction
    {
        public static void Heal(UnturnedPlayer player, byte amount)
        {
            player.Player.life.serverModifyFood(amount);
            player.Player.life.serverModifyHallucination(amount);
            player.Player.life.serverModifyHealth(amount);
            player.Player.life.serverModifyStamina(amount);
            player.Player.life.serverModifyVirus(amount);
            player.Player.life.serverModifyWarmth(amount);
            player.Player.life.serverModifyWater(amount);
            player.Player.life.serverSetBleeding(false);
            player.Player.life.serverSetLegsBroken(false);
        }
    }
}
