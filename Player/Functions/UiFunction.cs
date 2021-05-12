using System.Reflection;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

namespace SolokLibrary.Player.Functions
{
    public static class UiFunction
    {
        public static void ClearUiById(CSteamID steamId, ushort uiId)
        {
            var transportConnection = Provider.findTransportConnection(steamId);
            EffectManager.askEffectClearByID(uiId, transportConnection);
        }
        public static void HideDeathMenu(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowDeathMenu);
        public static void HideFood(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowFood);
        public static void HideForceBlur(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.ForceBlur);
        public static void HideHealth(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowHealth);
        public static void HideInteractWithEnemy(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowInteractWithEnemy);
        public static void HideLifeMeter(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowLifeMeters);
        public static void HideModal(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
        public static void HideNoBlur(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.NoBlur);
        public static void HideOxygen(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowOxygen);
        public static void HideStamina(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowStamina);
        public static void HideStatusIcon(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowStatusIcons);
        public static void HideVirus(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowVirus);
        public static void HideWater(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowWater);
        public static void SendEffect(CSteamID steamId, ushort uiId, Vector3 position)
        {
            var transportConnection = Provider.findTransportConnection(steamId);
            EffectManager.sendEffect(uiId, transportConnection, position);
        }
        public static void SendImageToUi(CSteamID steamId, short uiShortId, string childName, string url)
        {
            var transportConnection = Provider.findTransportConnection(steamId);
            EffectManager.sendUIEffectImageURL(uiShortId, transportConnection, true, childName, url);
        }
        public static void SendTextToUi(CSteamID steamId, short uiShortId, string childName, string text)
        {
            var transportConnection = Provider.findTransportConnection(steamId);
            EffectManager.sendUIEffectText(uiShortId, transportConnection, true, childName, text);
        }
        public static void SendUi(CSteamID steamId, ushort uiId, short uiShortId)
        {
            var transportConnection = Provider.findTransportConnection(steamId);
            EffectManager.sendUIEffect(uiId, uiShortId, transportConnection, true);
        }
        public static void SendUi(CSteamID steamId, ushort uiId, short uiShortId, object arg0)
        {
            var transportConnection = Provider.findTransportConnection(steamId);
            EffectManager.sendUIEffect(uiId, uiShortId, transportConnection, true, arg0.ToString());
        }
        public static void SendUi(CSteamID steamId, ushort uiId, short uiShortId, object arg0, object arg1)
        {
            var transportConnection = Provider.findTransportConnection(steamId);
            EffectManager.sendUIEffect(uiId, uiShortId, transportConnection, true, arg0.ToString(), arg1.ToString());
        }
        public static void SendUi(CSteamID steamId, ushort uiId, short uiShortId, object arg0, object arg1, object arg2)
        {
            var transportConnection = Provider.findTransportConnection(steamId);
            EffectManager.sendUIEffect(uiId, uiShortId, transportConnection, true, arg0.ToString(), arg1.ToString(),
                arg2.ToString());
        }
        public static void SendUi(CSteamID steamId, ushort uiId, short uiShortId, object arg0, object arg1, object arg2,
            object arg3)
        {
            var transportConnection = Provider.findTransportConnection(steamId);
            EffectManager.sendUIEffect(uiId, uiShortId, transportConnection, true, arg0.ToString(), arg1.ToString(),
                arg2.ToString(), arg3.ToString());
        }
        public static void SetUiVisibility(CSteamID steamId, short uiShortId, string childName, bool visible)
        {
            var transportConnection = Provider.findTransportConnection(steamId);
            EffectManager.sendUIEffectVisibility(uiShortId, transportConnection, true, childName, visible);
        }
        public static void ShowDeathMenu(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowDeathMenu);
        public static void ShowFood(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowFood);
        public static void ShowForceBlur(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.enablePluginWidgetFlag(EPluginWidgetFlags.ForceBlur);
        public static void ShowHealth(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowHealth);
        public static void ShowInteractWithEnemy(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowInteractWithEnemy);
        public static void ShowLifeMeter(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowLifeMeters);
        public static void ShowModal(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.enablePluginWidgetFlag(EPluginWidgetFlags.Modal);
        public static void ShowNoBlur(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.NoBlur);
        public static void ShowOxygen(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowOxygen);
        public static void ShowStamina(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowStamina);
        public static void ShowStatusIcon(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.enablePluginWidgetFlag(EPluginWidgetFlags.ShowStatusIcons);
        public static void ShowVirus(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowVirus);
        public static void ShowWater(CSteamID steamId) => UnturnedPlayer.FromCSteamID(steamId).Player.disablePluginWidgetFlag(EPluginWidgetFlags.ShowWater);
    }
}