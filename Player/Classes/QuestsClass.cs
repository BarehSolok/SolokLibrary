using System.Collections.Generic;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

namespace SolokLibrary.Player.Classes
{
    public class QuestsClass
    {
        // PVT. FIELDS
        private readonly CSteamID _steamID;
        
        // CONSTRUCTOR
        public QuestsClass(CSteamID steamID)
        {
            _steamID = steamID;
        }
        
        // PROPS
        public EPlayerGroupRank GroupRank => UnturnedPlayer.FromCSteamID(_steamID).Player.quests.groupRank;
        public bool IsMarkerPlaced => UnturnedPlayer.FromCSteamID(_steamID).Player.quests.isMarkerPlaced;
        public List<PlayerQuest> QuestsList => UnturnedPlayer.FromCSteamID(_steamID).Player.quests.questsList;
        public Vector3 MarkerPosition => UnturnedPlayer.FromCSteamID(_steamID).Player.quests.markerPosition;
        public string MarkerText => UnturnedPlayer.FromCSteamID(_steamID).Player.quests.markerTextOverride;
        public uint RadioFrequency
        {
            get => UnturnedPlayer.FromCSteamID(_steamID).Player.quests.radioFrequency;
            set => UnturnedPlayer.FromCSteamID(_steamID).Player.quests.sendSetRadioFrequency(value);
        }
    }
}