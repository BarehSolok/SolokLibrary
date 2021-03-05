using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API;
using AtomicLibrary.Player;
using Rocket.Unturned.Player;

namespace AtomicLibrary
{
    public class ExampleClass : APlugin<ExampleConfiguration>
    {
        public void ExampleMethod(UnturnedPlayer player)
        {
            APlayer aPlayer = new APlayer();
            aPlayer.Convert(player);
            //...
        }
    }

    public class ExampleConfiguration : IRocketPluginConfiguration
    {
        public void LoadDefaults()
        {
            throw new NotImplementedException();
        }
    }
}
