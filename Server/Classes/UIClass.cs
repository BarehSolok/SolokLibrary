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
        public void ClearAllUI() => UIFunction.ClearAllUi();
        public void ClearAllUI(ushort uiId) => UIFunction.ClearAllUi(uiId);
    }
}