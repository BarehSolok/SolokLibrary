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
        private Functions Functions = new Functions();
        private Props props = new Props();
        private AtomicRaycasts Raycasts = new AtomicRaycasts();
        public void Convert(UnturnedPlayer player) => APlayer.steamID = player.CSteamID;

        public void Convert(IRocketPlayer RocketPlayer) => APlayer.steamID = ((UnturnedPlayer)RocketPlayer).CSteamID;
        public bool bleeding => UnturnedPlayer.FromCSteamID(steamID).Bleeding;
        public bool broken => UnturnedPlayer.FromCSteamID(steamID).Broken;
        public uint experience => UnturnedPlayer.FromCSteamID(steamID).Experience;
        public byte food => UnturnedPlayer.FromCSteamID(steamID).Hunger;
        public bool god => UnturnedPlayer.FromCSteamID(steamID).GodMode;
        public void gravity(float newGravity) => UnturnedPlayer.FromCSteamID(steamID).Player.movement.tellPluginGravityMultiplier(steamID, newGravity);
        public byte health => UnturnedPlayer.FromCSteamID(steamID).Health;
        public bool inVehicle => UnturnedPlayer.FromCSteamID(steamID).IsInVehicle;
        public string id => UnturnedPlayer.FromCSteamID(steamID).CSteamID.ToString();
        public bool isAdmin => UnturnedPlayer.FromCSteamID(steamID).IsAdmin;
        public void jumpHeight(float newJumpHeight) => UnturnedPlayer.FromCSteamID(steamID).Player.movement.sendPluginJumpMultiplier(newJumpHeight);
        public Vector3 marker => UnturnedPlayer.FromCSteamID(steamID).Player.quests.markerPosition;
        public string name => UnturnedPlayer.FromCSteamID(steamID).CharacterName;
        public Vector3 position => UnturnedPlayer.FromCSteamID(steamID).Position;
        public uint radioFrequency => UnturnedPlayer.FromCSteamID(steamID).Player.quests.radioFrequency;
        public void sendRadioFrequency(uint newRadioFrequency) => UnturnedPlayer.FromCSteamID(steamID).Player.quests.sendSetRadioFrequency(newRadioFrequency);
        public int reputation => UnturnedPlayer.FromCSteamID(steamID).Reputation;
        public float speed => UnturnedPlayer.FromCSteamID(steamID).Player.movement.speed;
        public void sendSpeed(float newSpeed) => UnturnedPlayer.FromCSteamID(steamID).Player.movement.sendPluginSpeedMultiplier(newSpeed);
        public bool vanish => UnturnedPlayer.FromCSteamID(steamID).VanishMode;
        public byte virus => UnturnedPlayer.FromCSteamID(steamID).Player.life.virus;
        public byte water => UnturnedPlayer.FromCSteamID(steamID).Thirst;
        public bool arrested => props.arrested.arrested(UnturnedPlayer.FromCSteamID(steamID));
        public void addGroup(string groupID) => Functions.addGroup.addGroup(UnturnedPlayer.FromCSteamID(steamID), groupID);
        public void arrestPlayer() => Functions.arrestPlayer.arrestPlayer(UnturnedPlayer.FromCSteamID(steamID));
        public void browserRequest(string msg, string url) => Functions.browserRequest.browserRequest(UnturnedPlayer.FromCSteamID(steamID), msg, url);
        public void damage(byte amount) => Functions.damage.damage(UnturnedPlayer.FromCSteamID(steamID), amount);
        public void hasGroup(string groupID) => Functions.hasGroup.hasGroup(UnturnedPlayer.FromCSteamID(steamID), groupID);
        public void hasPermission(string permission) => Functions.hasPermission.hasPermission(UnturnedPlayer.FromCSteamID(steamID), permission);
        public void heal(byte amount) => Functions.heal.heal(UnturnedPlayer.FromCSteamID(steamID), amount);
        public void kick(string reason) => Functions.kick.kick(UnturnedPlayer.FromCSteamID(steamID), reason);
        public void kill() => Functions.kill.kill(UnturnedPlayer.FromCSteamID(steamID));
        public void maxSkills() => Functions.maxSkills.maxSkills(UnturnedPlayer.FromCSteamID(steamID));
        public void release() => Functions.release.release(UnturnedPlayer.FromCSteamID(steamID));
        public void removeFromVehicle() => Functions.removeFromVehicle.removeFromVehicle(UnturnedPlayer.FromCSteamID(steamID));
        public void removeGroup(string groupID) => Functions.removeGroup.removeGroup(UnturnedPlayer.FromCSteamID(steamID), groupID);
        public void setMarker(UnityEngine.Vector3 vector3) => Functions.setMarker.setMarker(UnturnedPlayer.FromCSteamID(steamID), vector3);
        public void sudo(string text) => Functions.sudo.sudo(UnturnedPlayer.FromCSteamID(steamID), text);
        public void teleport(UnityEngine.Vector3 vector3) => Functions.teleport.teleport(UnturnedPlayer.FromCSteamID(steamID), vector3);
        public UnturnedPlayer lookPlayer(float distance)
        {
            Raycasts.playerRaycast(UnturnedPlayer.FromCSteamID(steamID), distance);
            return Raycasts.lookedPlayer;
        }
        public BarricadeDrop lookBarricade(float distance)
        {
            Raycasts.barricadeRaycast(UnturnedPlayer.FromCSteamID(steamID), distance);
            return Raycasts.lookedBarricadeDrop;
        }
        public StructureDrop lookStructure(float distance)
        {
            Raycasts.structureRaycast(UnturnedPlayer.FromCSteamID(steamID), distance);
            return Raycasts.lookedStructureDrop;
        }
    }
}
