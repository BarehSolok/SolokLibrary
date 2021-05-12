using Rocket.Unturned.Player;

namespace SolokLibrary.Player.Functions
{
    public static class ItemFunction
    {
        public static void GiveItem(UnturnedPlayer player, ushort itemId, byte amount)
        {
            player.GiveItem(itemId, amount);
        }
        public static void RemoveItem(UnturnedPlayer player, ushort itemId)
        {
            for (byte page = 0; page < player.Inventory.items.Length; page++)
            for (byte index = 0; index < player.Inventory.items[page].getItemCount(); index++)
                if (player.Inventory.items[page].getItem(index) != null &&
                    player.Inventory.items[page].getItem(index).item.id == itemId)
                    player.Inventory.removeItem(page, index);
        }
    }
}