using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;

namespace SolokLibrary.Player.Classes
{
    public class ClothingClass
    {
        // PVT. FIELDS
        private readonly CSteamID _steamID;
        
        // CONSTRUCTOR
        public ClothingClass(CSteamID steamID)
        {
            _steamID = steamID;
        }
        
        // PROPS
        public ItemBackpackAsset BackpackAsset => UnturnedPlayer.FromCSteamID(_steamID).Player.clothing.backpackAsset;
        public ItemGlassesAsset GlassesAsset => UnturnedPlayer.FromCSteamID(_steamID).Player.clothing.glassesAsset;
        public ItemHatAsset HatAsset => UnturnedPlayer.FromCSteamID(_steamID).Player.clothing.hatAsset;
        public ItemMaskAsset MaskAsset => UnturnedPlayer.FromCSteamID(_steamID).Player.clothing.maskAsset;
        public ItemPantsAsset PantsAsset => UnturnedPlayer.FromCSteamID(_steamID).Player.clothing.pantsAsset;
        public ItemShirtAsset ShirtAsset => UnturnedPlayer.FromCSteamID(_steamID).Player.clothing.shirtAsset;
        public ItemVestAsset VestAsset => UnturnedPlayer.FromCSteamID(_steamID).Player.clothing.vestAsset;
    }
}