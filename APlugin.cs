﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API;
using Rocket.Core;
using Rocket.Core.Assets;
using Rocket.Core.Plugins;
using AtomicLibrary.Player;
using System.IO;

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

		private IAsset<RocketPluginConfiguration> configuration;

		public APlayer APlayer = new APlayer();


	}
}
