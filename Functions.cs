using AtomicLibrary.Player.Funcs;

namespace AtomicLibrary
{
    public class Functions
    {
        public AddGroup addGroup = new AddGroup();
        public ArrestPlayer arrestPlayer = new ArrestPlayer();
        public BrowserRequest browserRequest = new BrowserRequest();
        public Damage damage = new Damage();
        public HasGroup hasGroup = new HasGroup();
        public HasPermission hasPermission = new HasPermission();
        public Heal heal = new Heal();
        public Kick kick = new Kick();
        public Kill kill = new Kill();
        public MaxSkills maxSkills = new MaxSkills();
        public RemoveFromVehicle removeFromVehicle = new RemoveFromVehicle();
        public RemoveGroup removeGroup = new RemoveGroup();
        public SetMarker setMarker = new SetMarker();
        public Sudo sudo = new Sudo();
        public Teleport teleport = new Teleport();
        public Release release = new Release();
    }
}
