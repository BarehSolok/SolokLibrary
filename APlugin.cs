using System;
using System.Linq;
using Rocket.API;
using Rocket.Core;
using Rocket.Core.Assets;
using Rocket.Core.Plugins;
using AtomicLibrary.Player;
using System.IO;
using AtomicLibrary.Discord;
using AtomicLibrary.Logger;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;

namespace AtomicLibrary
{
	public class APlugin<RocketPluginConfiguration> : RocketPlugin, IRocketPlugin<RocketPluginConfiguration>, IRocketPlugin where RocketPluginConfiguration : class, IRocketPluginConfiguration
	{
		public IAsset<RocketPluginConfiguration> Configuration => configuration;

		public override void LoadPlugin()
		{
			configuration.Load(delegate (IAsset<RocketPluginConfiguration> asset)
			{
				LoadPlugin();
			});
		}

		public APlugin()
		{
			string text = Path.Combine(Directory, string.Format(Rocket.Core.Environment.PluginConfigurationFileTemplate, Name));
			string uriString = "";
			bool enabled = R.Settings.Instance.WebConfigurations.Enabled;
			if (enabled)
				uriString = string.Format(Rocket.Core.Environment.WebConfigurationTemplate, R.Settings.Instance.WebConfigurations.Url, Name, R.Implementation.InstanceId);
			else
				if (File.Exists(text))
					uriString = File.ReadAllLines(text).First<string>().Trim();
			Uri uri;
			if (Uri.TryCreate(uriString, UriKind.Absolute, out uri))
			{
				configuration = new WebXMLFileAsset<RocketPluginConfiguration>(uri, null, delegate (IAsset<RocketPluginConfiguration> asset)
				{
					LoadPlugin();
				});
			}
			else
				configuration = new XMLFileAsset<RocketPluginConfiguration>(text, null, default(RocketPluginConfiguration));
		}

		public static uint serverIP() => Provider.ip;
		public static string serverMap() => Provider.map;
		public static int serverPlayerCount() => Provider.clients.Count;
		public static int serverPlayerMaxPlayers() => Provider.clients.Capacity;
		public static string serverPassword() => Provider.serverPassword;
		public static string serverName() => Provider.serverName;
		public static string serverID() => Provider.serverID;
		public static ushort serverPort() => Provider.port;

		public static void ban(CSteamID steamID, string reason, uint duration) => UnturnedPlayer.FromCSteamID(steamID).Ban(reason, duration);

		private IAsset<RocketPluginConfiguration> configuration;
	}
}
