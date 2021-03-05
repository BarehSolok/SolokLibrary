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
        public static CSteamID steamID { get; set; }
        public void Convert(UnturnedPlayer player) => APlayer.steamID = player.CSteamID;
        public void Convert(IRocketPlayer RocketPlayer) => APlayer.steamID = ((UnturnedPlayer)RocketPlayer).CSteamID;

        public ulong CSteamID => APlayer.steamID.m_SteamID;

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
        public bool arrested => Properties.Arrested.arrested(UnturnedPlayer.FromCSteamID(steamID));
        public void addGroup(string groupID) => Funcs.AddGroup.addGroup(UnturnedPlayer.FromCSteamID(steamID), groupID);
        public void arrestPlayer() => Funcs.ArrestPlayer.arrestPlayer(UnturnedPlayer.FromCSteamID(steamID));
        public void browserRequest(string msg, string url) => Funcs.BrowserRequest.browserRequest(UnturnedPlayer.FromCSteamID(steamID), msg, url);
        public void damage(byte amount) => Funcs.Damage.damage(UnturnedPlayer.FromCSteamID(steamID), amount);
        public void hasGroup(string groupID) => Funcs.HasGroup.hasGroup(UnturnedPlayer.FromCSteamID(steamID), groupID);
        public void hasPermission(string permission) => Funcs.HasPermission.hasPermission(UnturnedPlayer.FromCSteamID(steamID), permission);
        public void heal(byte amount) => Funcs.Heal.heal(UnturnedPlayer.FromCSteamID(steamID), amount);
        public void kick(string reason) => Funcs.Kick.kick(UnturnedPlayer.FromCSteamID(steamID), reason);
        public void kill() => Funcs.Kill.kill(UnturnedPlayer.FromCSteamID(steamID));
        public void maxSkills() => Funcs.MaxSkills.maxSkills(UnturnedPlayer.FromCSteamID(steamID));
        public void release() => Funcs.Release.release(UnturnedPlayer.FromCSteamID(steamID));
        public void removeFromVehicle() => Funcs.RemoveFromVehicle.removeFromVehicle(UnturnedPlayer.FromCSteamID(steamID));
        public void removeGroup(string groupID) => Funcs.RemoveGroup.removeGroup(UnturnedPlayer.FromCSteamID(steamID), groupID);
        public void setMarker(UnityEngine.Vector3 vector3) => Funcs.SetMarker.setMarker(UnturnedPlayer.FromCSteamID(steamID), vector3);
        public void sudo(string text) => Funcs.Sudo.sudo(UnturnedPlayer.FromCSteamID(steamID), text);
        public void teleport(UnityEngine.Vector3 vector3) => Funcs.Teleport.teleport(UnturnedPlayer.FromCSteamID(steamID), vector3);
        public void ban(string reason, uint duration) => UnturnedPlayer.FromCSteamID(steamID).Ban(reason, duration);
        public void spy() => UnturnedPlayer.FromCSteamID(steamID).Player.sendScreenshot(steamID);
        public UnturnedPlayer lookPlayer(float distance)
        {
            AtomicRaycasts.playerRaycast(UnturnedPlayer.FromCSteamID(steamID), distance);
            return AtomicRaycasts.lookedPlayer;
        }
        public BarricadeDrop lookBarricade(float distance)
        {
            AtomicRaycasts.barricadeRaycast(UnturnedPlayer.FromCSteamID(steamID), distance);
            return AtomicRaycasts.lookedBarricadeDrop;
        }
        public StructureDrop lookStructure(float distance)
        {
            AtomicRaycasts.structureRaycast(UnturnedPlayer.FromCSteamID(steamID), distance);
            return AtomicRaycasts.lookedStructureDrop;
        }
    }
}
