using SDG.Unturned;

namespace SolokLibrary.Server.Functions
{
    public static class UIFunction
    {
        public static void ClearAllUi()
        {
            EffectManager.askEffectClearAll();
        }
        public static void ClearAllUi(ushort uiId)
        {
            EffectManager.ClearEffectByID_AllPlayers(uiId);
        }
        // public static Dictionary<short, GameObject> IndexedUIEffects()
        // {
        //     var indexedUIEffects = typeof(EffectManager).GetField("indexedUIEffects", BindingFlags.Static | BindingFlags.NonPublic);
        //     return (Dictionary<short, GameObject>)indexedUIEffects?.GetValue(null);
        // }
    }
}