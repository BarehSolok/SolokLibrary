using System.Linq;
using Rocket.Unturned.Player;
using SDG.Unturned;
using UnityEngine;

namespace SolokLibrary.Player.Properties
{
    public static class LocationPlayer
    {
        public static string Location(UnturnedPlayer player)
        {
            var node = LevelNodes.nodes.OfType<LocationNode>().OrderBy(k => Vector3.Distance(k.point, player.Position)).FirstOrDefault();
            return node?.name;
        }
        public static string Location(SPlayer player)
        {
            var node = LevelNodes.nodes.OfType<LocationNode>().OrderBy(k => Vector3.Distance(k.point, player.Position)).FirstOrDefault();
            return node?.name;
        }
    }
}