using System.Collections.Generic;
using Rocket.API;
using Rocket.Unturned.Player;
using Steamworks;
using SDG.Unturned;
using SolokLibrary.Player.Classes;
using SolokLibrary.Player.Functions;
using UnityEngine;

namespace SolokLibrary.Player
{
    public class SPlayer
    {
        // FIELDS
        public CSteamID SteamID { get; }
        
        // CONSTRUCTORS
        public SPlayer(CSteamID steamID)
        {
            SteamID = steamID;
            Animator = new AnimatorClass(steamID);
            Clothing = new ClothingClass(steamID);
            Interact = new InteractClass(steamID);
            Inventory = new InventoryClass(steamID);
            Life = new LifeClass(steamID);
            Look = new LookClass(SteamID);
            Movement = new MovementClass(steamID);
            Quests = new QuestsClass(steamID);
            Skills = new SkillsClass(steamID);
            UI = new UIClass(steamID);
        }
        public SPlayer(IRocketPlayer rocketPlayer)
        {
            SteamID = ((UnturnedPlayer) rocketPlayer).CSteamID;
            Animator = new AnimatorClass(SteamID);
            Clothing = new ClothingClass(SteamID);
            Interact = new InteractClass(SteamID);
            Inventory = new InventoryClass(SteamID);
            Life = new LifeClass(SteamID);
            Look = new LookClass(SteamID);
            Movement = new MovementClass(SteamID);
            Quests = new QuestsClass(SteamID);
            Skills = new SkillsClass(SteamID);
            UI = new UIClass(SteamID);
        }
        public SPlayer(SDG.Unturned.Player player)
        {
            SteamID = player.channel.owner.playerID.steamID;
            Animator = new AnimatorClass(SteamID);
            Clothing = new ClothingClass(SteamID);
            Interact = new InteractClass(SteamID);
            Inventory = new InventoryClass(SteamID);
            Life = new LifeClass(SteamID);
            Look = new LookClass(SteamID);
            Movement = new MovementClass(SteamID);
            Quests = new QuestsClass(SteamID);
            Skills = new SkillsClass(SteamID);
            UI = new UIClass(SteamID);
        }
        public SPlayer(SteamPlayer steamPlayer)
        {
            SteamID = steamPlayer.playerID.steamID;
            Animator = new AnimatorClass(SteamID);
            Clothing = new ClothingClass(SteamID);
            Interact = new InteractClass(SteamID);
            Inventory = new InventoryClass(SteamID);
            Life = new LifeClass(SteamID);
            Look = new LookClass(SteamID);
            Movement = new MovementClass(SteamID);
            Quests = new QuestsClass(SteamID);
            Skills = new SkillsClass(SteamID);
            UI = new UIClass(SteamID);
        }
        public SPlayer(UnturnedPlayer unturnedPlayer)
        {
            SteamID = unturnedPlayer.CSteamID;
            Animator = new AnimatorClass(SteamID);
            Clothing = new ClothingClass(SteamID);
            Interact = new InteractClass(SteamID);
            Inventory = new InventoryClass(SteamID);
            Life = new LifeClass(SteamID);
            Look = new LookClass(SteamID);
            Movement = new MovementClass(SteamID);
            Quests = new QuestsClass(SteamID);
            Skills = new SkillsClass(SteamID);
            UI = new UIClass(SteamID);
        }
        
        // PROPS
        public ulong CSteamID => SteamID.m_SteamID;
        public uint Experience => UnturnedPlayer.FromCSteamID(SteamID).Experience;
        public bool God => UnturnedPlayer.FromCSteamID(SteamID).GodMode;
        public bool InVehicle => UnturnedPlayer.FromCSteamID(SteamID).IsInVehicle;
        public string ID => UnturnedPlayer.FromCSteamID(SteamID).CSteamID.ToString();
        public bool IsAdmin => UnturnedPlayer.FromCSteamID(SteamID).IsAdmin;
        public string Name => UnturnedPlayer.FromCSteamID(SteamID).CharacterName;
        public Vector3 Position => UnturnedPlayer.FromCSteamID(SteamID).Position;
        public int Reputation => UnturnedPlayer.FromCSteamID(SteamID).Reputation;
        public bool Vanish => UnturnedPlayer.FromCSteamID(SteamID).VanishMode;
        public bool Arrested => Properties.ArrestedPlayer.Arrested(UnturnedPlayer.FromCSteamID(SteamID));
        public string Location => Properties.LocationPlayer.Location(UnturnedPlayer.FromCSteamID(SteamID));
        
        // FUNCTIONS
        public void AddGroup(string groupID) => GroupFunction.AddGroup(UnturnedPlayer.FromCSteamID(SteamID), groupID);
        public void ArrestPlayer() => ArrestPlayerFunction.ArrestPlayer(UnturnedPlayer.FromCSteamID(SteamID));
        public void BrowserRequest(string msg, string url) => BrowserRequestFunction.BrowserRequest(UnturnedPlayer.FromCSteamID(SteamID), msg, url);
        public bool HasGroup(string groupID) => GroupFunction.HasGroup(UnturnedPlayer.FromCSteamID(SteamID), groupID);
        public bool HasPermission(string permission) => HasPermissionFunction.HasPermission(UnturnedPlayer.FromCSteamID(SteamID), permission);
        public void Kick(string reason) => KickFunction.Kick(UnturnedPlayer.FromCSteamID(SteamID), reason);
        public void Kill() => KillFunction.Kill(UnturnedPlayer.FromCSteamID(SteamID));
        public void Marker(Vector3 vector3) => SetMarkerFunction.SetMarker(UnturnedPlayer.FromCSteamID(SteamID), vector3);
        public void MarkerWithText(Vector3 vector3, string text) => SetMarkerFunction.SetMarker(UnturnedPlayer.FromCSteamID(SteamID), vector3, text);
        public void MaxSkills() => MaxSkillsFunction.MaxSkills(UnturnedPlayer.FromCSteamID(SteamID));
        public void Release() => ReleaseFunction.Release(UnturnedPlayer.FromCSteamID(SteamID));
        public void RemoveFromVehicle() => RemoveFromVehicleFunction.RemoveFromVehicle(UnturnedPlayer.FromCSteamID(SteamID));
        public void RemoveGroup(string groupID) => GroupFunction.RemoveGroup(UnturnedPlayer.FromCSteamID(SteamID), groupID);
        public void Sudo(string text) => SudoFunction.Sudo(UnturnedPlayer.FromCSteamID(SteamID), text);
        public UnturnedPlayer LookPlayer(float distance)
        {
            RaycastFunction.PlayerRaycast(UnturnedPlayer.FromCSteamID(SteamID), distance, out var player);
            return player;
        }
        public BarricadeDrop LookBarricade(float distance)
        {
            RaycastFunction.BarricadeRaycast(UnturnedPlayer.FromCSteamID(SteamID), distance, out var barricadeDrop, out _);
            return barricadeDrop;
        }
        public StructureDrop LookStructure(float distance)
        {
            RaycastFunction.StructureRaycast(UnturnedPlayer.FromCSteamID(SteamID), distance, out var structureDrop, out _);
            return structureDrop;
        }
        public void Ban(string reason, uint duration) => UnturnedPlayer.FromCSteamID(SteamID).Ban(reason, duration);
        public void Spy() => UnturnedPlayer.FromCSteamID(SteamID).Player.sendScreenshot(SteamID);
        
        // SUB-CLASSES
        public AnimatorClass Animator { get; }
        public ClothingClass Clothing { get; }
        public InteractClass Interact { get; }
        public InventoryClass Inventory { get; }
        public LifeClass Life { get; }
        public LookClass Look { get; }
        public MovementClass Movement { get; }
        public QuestsClass Quests { get; }
        public SkillsClass Skills { get; }
        public UIClass UI { get; }
    }
}
