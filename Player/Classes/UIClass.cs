using Steamworks;
using UnityEngine;

namespace SolokLibrary.Player.Classes
{
    public class UIClass
    {
        // PVT. FIELDS
        private readonly CSteamID _steamID;
        private bool _deathMenu = false;
        private bool _food = false;
        private bool _forceBlur = false;
        private bool _health = false;
        private bool _interactWithEnemy = false;
        private bool _lifeMeter = false;
        private bool _modal = false;
        private bool _noBlur = false;
        private bool _oxygen = false;
        private bool _stamina = false;
        private bool _statusIcon = false;
        private bool _virus = false;
        private bool _water = false;
        
        // CONSTRUCTOR
        public UIClass(CSteamID steamID)
        {
            _steamID = steamID;
        }
        
        // PROPS
        public bool DeathMenu
        {
            get => _deathMenu;
            set
            {
                if (value)
                {
                    Functions.UiFunction.ShowDeathMenu(_steamID);
                    _deathMenu = true;
                }
                else
                {
                    Functions.UiFunction.HideDeathMenu(_steamID);
                    _deathMenu = false;
                }
            }
        }
        public bool Food
        {
            get => _food;
            set
            {
                if (value)
                {
                    Functions.UiFunction.ShowFood(_steamID);
                    _food = true;
                }
                else
                {
                    Functions.UiFunction.HideFood(_steamID);
                    _food = false;
                }
            }
        }
        public bool ForceBlur
        {
            get => _forceBlur;
            set
            {
                if (value)
                {
                    Functions.UiFunction.ShowForceBlur(_steamID);
                    _forceBlur = true;
                }
                else
                {
                    Functions.UiFunction.HideForceBlur(_steamID);
                    _forceBlur = false;
                }
            }
        }
        public bool Health
        {
            get => _health;
            set
            {
                if (value)
                {
                    Functions.UiFunction.ShowHealth(_steamID);
                    _health = true;
                }
                else
                {
                    Functions.UiFunction.HideHealth(_steamID);
                    _health = false;
                }
            }
        }
        public bool InteractWithEnemy
        {
            get => _interactWithEnemy;
            set
            {
                if (value)
                {
                    Functions.UiFunction.ShowInteractWithEnemy(_steamID);
                    _interactWithEnemy = true;
                }
                else
                {
                    Functions.UiFunction.HideInteractWithEnemy(_steamID);
                    _interactWithEnemy = false;
                }
            }
        }
        public bool LifeMeter
        {
            get => _lifeMeter;
            set
            {
                if (value)
                {
                    Functions.UiFunction.ShowLifeMeter(_steamID);
                    _lifeMeter = true;
                }
                else
                {
                    Functions.UiFunction.HideLifeMeter(_steamID);
                    _lifeMeter = false;
                }
            }
        }
        public bool Modal
        {
            get => _modal;
            set
            {
                if (value)
                {
                    Functions.UiFunction.ShowModal(_steamID);
                    _modal = true;
                }
                else
                {
                    Functions.UiFunction.HideModal(_steamID);
                    _modal = false;
                }
            }
        }
        public bool NoBlur
        {
            get => _noBlur;
            set
            {
                if (value)
                {
                    Functions.UiFunction.ShowNoBlur(_steamID);
                    _noBlur = true;
                }
                else
                {
                    Functions.UiFunction.HideNoBlur(_steamID);
                    _noBlur = false;
                }
            }
        }
        public bool Oxygen
        {
            get => _oxygen;
            set
            {
                if (value)
                {
                    Functions.UiFunction.ShowOxygen(_steamID);
                    _oxygen = true;
                }
                else
                {
                    Functions.UiFunction.HideOxygen(_steamID);
                    _oxygen = false;
                }
            }
        }
        public bool Stamina
        {
            get => _stamina;
            set
            {
                if (value)
                {
                    Functions.UiFunction.ShowStamina(_steamID);
                    _stamina = true;
                }
                else
                {
                    Functions.UiFunction.HideStamina(_steamID);
                    _stamina = false;
                }
            }
        }
        public bool StatusIcon
        {
            get => _statusIcon;
            set
            {
                if (value)
                {
                    Functions.UiFunction.ShowStatusIcon(_steamID);
                    _statusIcon = true;
                }
                else
                {
                    Functions.UiFunction.HideStatusIcon(_steamID);
                    _statusIcon = false;
                }
            }
        }
        public bool Virus
        {
            get => _virus;
            set
            {
                if (value)
                {
                    Functions.UiFunction.ShowVirus(_steamID);
                    _virus = true;
                }
                else
                {
                    Functions.UiFunction.HideVirus(_steamID);
                    _virus = false;
                }
            }
        }
        public bool Water
        {
            get => _water;
            set
            {
                if (value)
                {
                    Functions.UiFunction.ShowWater(_steamID);
                    _water = true;
                }
                else
                {
                    Functions.UiFunction.HideWater(_steamID);
                    _water = false;
                }
            }
        }
        
        // METHODS
        public void ClearUiById(ushort uiId) => Functions.UiFunction.ClearUiById(_steamID, uiId);
        public void SendEffect(ushort uiId, Vector3 position) => Functions.UiFunction.SendEffect(_steamID, uiId, position);
        public void SendImageToUi(short uiShortId, string childName, string url) => Functions.UiFunction.SendImageToUi(_steamID, uiShortId, childName, url);
        public void SendTextToUi(short uiShortId, string childName, string text) => Functions.UiFunction.SendTextToUi(_steamID, uiShortId, childName, text);
        public void SendUi(ushort uiId, short uiShortId) => Functions.UiFunction.SendUi(_steamID, uiId, uiShortId);
        public void SendUi(ushort uiId, short uiShortId, object arg0) => Functions.UiFunction.SendUi(_steamID, uiId, uiShortId, arg0);
        public void SendUi(ushort uiId, short uiShortId, object arg0, object arg1) => Functions.UiFunction.SendUi(_steamID, uiId, uiShortId, arg0, arg1);
        public void SendUi(ushort uiId, short uiShortId, object arg0, object arg1, object arg2) => Functions.UiFunction.SendUi(_steamID, uiId, uiShortId, arg0, arg1, arg2);
        public void SendUi(ushort uiId, short uiShortId, object arg0, object arg1, object arg2, object arg3) => Functions.UiFunction.SendUi(_steamID, uiId, uiShortId, arg0, arg1, arg2, arg3);
        public void SetUiVisibility(short uiShortId, string childName, bool visible) => Functions.UiFunction.SetUiVisibility(_steamID, uiShortId, childName, visible);
    }
}