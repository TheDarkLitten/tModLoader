using Terraria.DataStructures;
using static Terraria.DataStructures.PlayerDrawHeadLayers;

namespace Terraria.ModLoader
{
	/// <summary>
	/// This class represents a DrawLayer for the player's map icon, and uses PlayerDrawHeadInfo as its InfoType. Drawing should be done directly through drawInfo.spriteBatch.
	/// </summary>
	public class PlayerHeadLayer : DrawLayer<PlayerDrawHeadSet>
	{
		public static readonly PlayerHeadLayer BackHelmet = CreateVanillaLayer(nameof(BackHelmet), DrawPlayer_00_BackHelmet);
		public static readonly PlayerHeadLayer FaceSkin = CreateVanillaLayer(nameof(FaceSkin), DrawPlayer_01_FaceSkin);
		public static readonly PlayerHeadLayer DrawArmorWithFullHair = CreateVanillaLayer(nameof(DrawArmorWithFullHair), DrawPlayer_02_DrawArmorWithFullHair);
		public static readonly PlayerHeadLayer HelmetHair = CreateVanillaLayer(nameof(HelmetHair), DrawPlayer_03_HelmetHair);
		public static readonly PlayerHeadLayer JungleRose = CreateVanillaLayer(nameof(JungleRose), DrawPlayer_04_JungleRose);
		public static readonly PlayerHeadLayer TallHats = CreateVanillaLayer(nameof(TallHats), DrawPlayer_05_TallHats);
		public static readonly PlayerHeadLayer NormalHats = CreateVanillaLayer(nameof(NormalHats), DrawPlayer_06_NormalHats);
		public static readonly PlayerHeadLayer JustHair = CreateVanillaLayer(nameof(JustHair), DrawPlayer_07_JustHair);
		public static readonly PlayerHeadLayer FaceAcc = CreateVanillaLayer(nameof(FaceAcc), DrawPlayer_08_FaceAcc);

		/// <summary>
		/// Creates a PlayerHeadLayer with the given mod name, identifier name, and drawing action.
		/// </summary>
		public PlayerHeadLayer(string mod, string name, LayerFunction layer) : base(mod, name, layer) {
		}

		/// <summary>
		/// Creates a PlayerHeadLayer with the given mod name, identifier name, parent layer, and drawing action.
		/// </summary>
		public PlayerHeadLayer(string mod, string name, PlayerHeadLayer parent, LayerFunction layer) : base(mod, name, parent, layer) {
		}

		private static PlayerHeadLayer CreateVanillaLayer(string name, LayerFunction layer) => new PlayerHeadLayer("Terraria", name, layer);
	}
}
