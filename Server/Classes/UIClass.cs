using SDG.Unturned;
using SolokLibrary.Server.Functions;

namespace SolokLibrary.Server.Classes
{
    public class UIClass
    {
        // FIELD
        public UIClass Instance;
        
        // CONSTRUCTOR
        public UIClass()
        {
            Instance = this;
        }

        // METHODS
        public static void ClearAllUI() => UIFunction.ClearAllUi();
        public static void ClearAllUI(ushort uiId) => UIFunction.ClearAllUi(uiId);
    }
}