using Rocket.API;
using Rocket.Unturned.Player;
using Steamworks;
using SDG.Unturned;
using AtomicLibrary.Raycasts;
using UnityEngine;

namespace AtomicLibrary.Player
{
    public class APlayer
    {
        static CSteamID steamID { get; set; }
        public static void Convert(UnturnedPlayer player) => APlayer.steamID = player.CSteamID;
        public static void Convert(IRocketPlayer RocketPlayer) => APlayer.steamID = ((UnturnedPlayer)RocketPlayer).CSteamID;
        public static bool bleeding => UnturnedPlayer.FromCSteamID(steamID).Bleeding;
        public static bool broken => UnturnedPlayer.FromCSteamID(steamID).Broken;
        public static uint experience => UnturnedPlayer.FromCSteamID(steamID).Experience;
        public static byte food => UnturnedPlayer.FromCSteamID(steamID).Hunger;
        public static bool god => UnturnedPlayer.FromCSteamID(steamID).GodMode;
        public static void gravity(float newGravity) => UnturnedPlayer.FromCSteamID(steamID).Player.movement.tellPluginGravityMultiplier(steamID, newGravity);
        public static byte health => UnturnedPlayer.FromCSteamID(steamID).Health;
        public static bool inVehicle => UnturnedPlayer.FromCSteamID(steamID).IsInVehicle;
        public static string id => UnturnedPlayer.FromCSteamID(steamID).CSteamID.ToString();
        public static bool isAdmin => UnturnedPlayer.FromCSteamID(steamID).IsAdmin;
        public static void jumpHeight(float newJumpHeight) => UnturnedPlayer.FromCSteamID(steamID).Player.movement.sendPluginJumpMultiplier(newJumpHeight);
        public static Vector3 marker => UnturnedPlayer.FromCSteamID(steamID).Player.quests.markerPosition;
        public static string name => UnturnedPlayer.FromCSteamID(steamID).CharacterName;
        public static Vector3 position => UnturnedPlayer.FromCSteamID(steamID).Position;
        public static uint radioFrequency => UnturnedPlayer.FromCSteamID(steamID).Player.quests.radioFrequency;
        public static void sendRadioFrequency(uint newRadioFrequency) => UnturnedPlayer.FromCSteamID(steamID).Player.quests.sendSetRadioFrequency(newRadioFrequency);
        public static int reputation => UnturnedPlayer.FromCSteamID(steamID).Reputation;
        public static float speed => UnturnedPlayer.FromCSteamID(steamID).Player.movement.speed;
        public static void sendSpeed(float newSpeed) => UnturnedPlayer.FromCSteamID(steamID).Player.movement.sendPluginSpeedMultiplier(newSpeed);
        public static bool vanish => UnturnedPlayer.FromCSteamID(steamID).VanishMode;
        public static byte virus => UnturnedPlayer.FromCSteamID(steamID).Player.life.virus;
        public static byte water => UnturnedPlayer.FromCSteamID(steamID).Thirst;
        public static bool arrested => Properties.Arrested.arrested(UnturnedPlayer.FromCSteamID(steamID));
        public static void addGroup(string groupID) => Funcs.AddGroup.addGroup(UnturnedPlayer.FromCSteamID(steamID), groupID);
        public static void arrestPlayer() => Funcs.ArrestPlayer.arrestPlayer(UnturnedPlayer.FromCSteamID(steamID));
        public static void browserRequest(string msg, string url) => Funcs.BrowserRequest.browserRequest(UnturnedPlayer.FromCSteamID(steamID), msg, url);
        public static void damage(byte amount) => Funcs.Damage.damage(UnturnedPlayer.FromCSteamID(steamID), amount);
        public static void hasGroup(string groupID) => Funcs.HasGroup.hasGroup(UnturnedPlayer.FromCSteamID(steamID), groupID);
        public static void hasPermission(string permission) => Funcs.HasPermission.hasPermission(UnturnedPlayer.FromCSteamID(steamID), permission);
        public static void heal(byte amount) => Funcs.Heal.heal(UnturnedPlayer.FromCSteamID(steamID), amount);
        public static void kick(string reason) => Funcs.Kick.kick(UnturnedPlayer.FromCSteamID(steamID), reason);
        public static void kill() => Funcs.Kill.kill(UnturnedPlayer.FromCSteamID(steamID));
        public static void maxSkills() => Funcs.MaxSkills.maxSkills(UnturnedPlayer.FromCSteamID(steamID));
        public static void release() => Funcs.Release.release(UnturnedPlayer.FromCSteamID(steamID));
        public static void removeFromVehicle() => Funcs.RemoveFromVehicle.removeFromVehicle(UnturnedPlayer.FromCSteamID(steamID));
        public static void removeGroup(string groupID) => Funcs.RemoveGroup.removeGroup(UnturnedPlayer.FromCSteamID(steamID), groupID);
        public static void setMarker(UnityEngine.Vector3 vector3) => Funcs.SetMarker.setMarker(UnturnedPlayer.FromCSteamID(steamID), vector3);
        public static void sudo(string text) => Funcs.Sudo.sudo(UnturnedPlayer.FromCSteamID(steamID), text);
        public static void teleport(UnityEngine.Vector3 vector3) => Funcs.Teleport.teleport(UnturnedPlayer.FromCSteamID(steamID), vector3);

        public static void ban(string reason, uint duration) => UnturnedPlayer.FromCSteamID(steamID).Ban(reason, duration);
        public static void spy() => UnturnedPlayer.FromCSteamID(steamID).Player.sendScreenshot(steamID);

        
        public static UnturnedPlayer lookPlayer(float distance)
        {
            AtomicRaycasts.playerRaycast(UnturnedPlayer.FromCSteamID(steamID), distance);
            return AtomicRaycasts.lookedPlayer;
        }
        public static BarricadeDrop lookBarricade(float distance)
        {
            AtomicRaycasts.barricadeRaycast(UnturnedPlayer.FromCSteamID(steamID), distance);
            return AtomicRaycasts.lookedBarricadeDrop;
        }
        public static StructureDrop lookStructure(float distance)
        {
            AtomicRaycasts.structureRaycast(UnturnedPlayer.FromCSteamID(steamID), distance);
            return AtomicRaycasts.lookedStructureDrop;
        }
    }
}
