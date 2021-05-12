using Rocket.Unturned.Player;
using SDG.Unturned;
using SolokLibrary.Player.Functions;
using Steamworks;

namespace SolokLibrary.Player.Classes
{
    public class LifeClass
    {
        // PVT. FIELDS
        private readonly CSteamID _steamID;
        
        // CONSTRUCTOR
        public LifeClass(CSteamID steamID)
        {
            _steamID = steamID;
        }
        
        // PROPS
        public bool Aggressor => UnturnedPlayer.FromCSteamID(_steamID).Player.life.isAggressor;
        public bool Bleeding
        {
            get => UnturnedPlayer.FromCSteamID(_steamID).Player.life.isBleeding;
            set => UnturnedPlayer.FromCSteamID(_steamID).Player.life.serverSetBleeding(value);
        }
        public bool Broken 
        {
            get => UnturnedPlayer.FromCSteamID(_steamID).Player.life.isBroken;
            set => UnturnedPlayer.FromCSteamID(_steamID).Player.life.serverSetLegsBroken(value);
        }
        public bool Dead => UnturnedPlayer.FromCSteamID(_steamID).Player.life.isDead;
        public byte Food
        {
            get => UnturnedPlayer.FromCSteamID(_steamID).Player.life.food;
            set
            {
                if (Food > value)
                    UnturnedPlayer.FromCSteamID(_steamID).Player.life.serverModifyFood(-(Food - value));
                else
                    UnturnedPlayer.FromCSteamID(_steamID).Player.life.serverModifyFood(value - Food);
            }
        }
        public byte Health
        {
            get => UnturnedPlayer.FromCSteamID(_steamID).Player.life.health;
            set
            {
                if (Health > value)
                    UnturnedPlayer.FromCSteamID(_steamID).Player.life.serverModifyHealth(-(Health - value));
                else
                    UnturnedPlayer.FromCSteamID(_steamID).Player.life.serverModifyHealth(value - Health);
            }
        }
        public float LastDeath => UnturnedPlayer.FromCSteamID(_steamID).Player.life.lastDeath;
        public float LastRespawn => UnturnedPlayer.FromCSteamID(_steamID).Player.life.lastRespawn;
        public byte Oxygen => UnturnedPlayer.FromCSteamID(_steamID).Player.life.oxygen;
        public byte Stamina
        {
            get => UnturnedPlayer.FromCSteamID(_steamID).Player.life.stamina;
            set
            {
                if (Stamina > value)
                    UnturnedPlayer.FromCSteamID(_steamID).Player.life.serverModifyStamina(-(Stamina - value));
                else
                    UnturnedPlayer.FromCSteamID(_steamID).Player.life.serverModifyStamina(value - Stamina);
            }
        }
        public EPlayerTemperature Temperature => UnturnedPlayer.FromCSteamID(_steamID).Player.life.temperature;
        public byte Virus
        {
            get => UnturnedPlayer.FromCSteamID(_steamID).Player.life.virus;
            set
            {
                if (Virus > value)
                    UnturnedPlayer.FromCSteamID(_steamID).Player.life.serverModifyVirus(-(Virus - value));
                else
                    UnturnedPlayer.FromCSteamID(_steamID).Player.life.serverModifyVirus(value - Virus);
            }
        }
        public byte Vision
        {
            get => UnturnedPlayer.FromCSteamID(_steamID).Player.life.vision;
            set
            {
                if (Vision > value)
                    UnturnedPlayer.FromCSteamID(_steamID).Player.life.serverModifyHallucination(-(Vision - value));
                else
                    UnturnedPlayer.FromCSteamID(_steamID).Player.life.serverModifyHallucination(value - Vision);
            }
        }
        public uint Warmth
        {
            get => UnturnedPlayer.FromCSteamID(_steamID).Player.life.warmth;
            set
            {
                if (Warmth > value)
                    UnturnedPlayer.FromCSteamID(_steamID).Player.life.serverModifyWarmth(-(Warmth - value));
                else
                    UnturnedPlayer.FromCSteamID(_steamID).Player.life.serverModifyWarmth(value - Warmth);
            }
        }
        public byte Water
        {
            get => UnturnedPlayer.FromCSteamID(_steamID).Player.life.water;
            set
            {
                if (Water > value)
                    UnturnedPlayer.FromCSteamID(_steamID).Player.life.serverModifyWater(-(Water - value));
                else
                    UnturnedPlayer.FromCSteamID(_steamID).Player.life.serverModifyWater(value - Water);
            }
        }
        
        // METHODS
        public void Damage(byte amount) => DamageFunction.Damage(UnturnedPlayer.FromCSteamID(_steamID), amount);
        public void Heal() => HealFunction.Heal(UnturnedPlayer.FromCSteamID(_steamID), 100);
        public void Heal(byte amount) => HealFunction.Heal(UnturnedPlayer.FromCSteamID(_steamID), amount);
    }
}