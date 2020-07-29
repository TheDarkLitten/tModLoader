using System.Collections.Generic;
using System.Linq;

namespace Terraria.ModLoader
{
	public static class PlayerLayerHooks
	{
		internal static readonly IList<PlayerLayer> layers = new List<PlayerLayer>();

		internal static void Add(PlayerLayer layer) => layers.Add(layer);

		internal static void Unload() => layers.Clear();

		public static void ModifyDrawLayers(Player drawPlayer, List<PlayerLayer> layerList) {
			var readonlyList = layerList.ToList().AsReadOnly(); //Duplicates the list.

			foreach (var layer in layers) {
				int index = -1;

				layer.Setup(drawPlayer, readonlyList, ref index);

				if (index >= 0 && index <= layerList.Count) {
					layerList.Insert(index, layer);
				}
			}
		}
	}
}
