using Terraria.DataStructures;
using static Terraria.DataStructures.PlayerDrawLayers;

namespace Terraria.ModLoader
{
	/// <summary>
	/// This class represents a DrawLayer for the player, and uses PlayerDrawInfo as its InfoType. Drawing should be done by adding Terraria.DataStructures.DrawData objects to Main.playerDrawData.
	/// </summary>
	public class PlayerLayer : DrawLayer<PlayerDrawSet>
	{
		public static readonly PlayerLayer TorsoIndent = CreateVanillaLayer(nameof(TorsoIndent), DrawPlayer_extra_TorsoPlus);
		public static readonly PlayerLayer TorsoUnindent = CreateVanillaLayer(nameof(TorsoUnindent), DrawPlayer_extra_TorsoMinus);
		public static readonly PlayerLayer MountIndent = CreateVanillaLayer(nameof(MountIndent), DrawPlayer_extra_MountPlus);
		public static readonly PlayerLayer MountUnindent = CreateVanillaLayer(nameof(MountUnindent), DrawPlayer_extra_MountMinus);

		public static readonly PlayerLayer BackHair = CreateVanillaLayer(nameof(BackHair), DrawPlayer_01_BackHair);
		public static readonly PlayerLayer JimsClock = CreateVanillaLayer(nameof(JimsClock), DrawPlayer_01_2_JimsCloak);
		public static readonly PlayerLayer BackHead = CreateVanillaLayer(nameof(BackHead), DrawPlayer_01_3_BackHead);
		public static readonly PlayerLayer MountBehindPlayer = CreateVanillaLayer(nameof(MountBehindPlayer), DrawPlayer_02_MountBehindPlayer);
		public static readonly PlayerLayer Carpet = CreateVanillaLayer(nameof(Carpet), DrawPlayer_03_Carpet);
		public static readonly PlayerLayer PortableStool = CreateVanillaLayer(nameof(PortableStool), DrawPlayer_03_PortableStool);
		public static readonly PlayerLayer ElectrifiedDebuffBack = CreateVanillaLayer(nameof(ElectrifiedDebuffBack), DrawPlayer_04_ElectrifiedDebuffBack);
		public static readonly PlayerLayer ForbiddenSetRing = CreateVanillaLayer(nameof(ForbiddenSetRing), DrawPlayer_05_ForbiddenSetRing);
		public static readonly PlayerLayer SafemanSun = CreateVanillaLayer(nameof(SafemanSun), DrawPlayer_05_2_SafemanSun);
		public static readonly PlayerLayer WebbedDebuffBack = CreateVanillaLayer(nameof(WebbedDebuffBack), DrawPlayer_06_WebbedDebuffBack);
		public static readonly PlayerLayer LeinforsHairShampoo = CreateVanillaLayer(nameof(LeinforsHairShampoo), DrawPlayer_07_LeinforsHairShampoo);
		public static readonly PlayerLayer Backpacks = CreateVanillaLayer(nameof(Backpacks), DrawPlayer_08_Backpacks);
		public static readonly PlayerLayer BackAccessory = CreateVanillaLayer(nameof(BackAccessory), DrawPlayer_09_BackAc);
		public static readonly PlayerLayer Wings = CreateVanillaLayer(nameof(Wings), DrawPlayer_10_Wings);
		public static readonly PlayerLayer Balloons = CreateVanillaLayer(nameof(Balloons), DrawPlayer_11_Balloons);
		public static readonly PlayerLayer HeldItem = CreateVanillaLayer(nameof(HeldItem), DrawPlayer_27_HeldItem);
		public static readonly PlayerLayer Skin = CreateVanillaLayer(nameof(Skin), DrawPlayer_12_Skin);
		public static readonly PlayerLayer Shoes = CreateVanillaLayer(nameof(Shoes), DrawPlayer_14_Shoes);
		public static readonly PlayerLayer Leggings = CreateVanillaLayer(nameof(Leggings), DrawPlayer_13_Leggings);
		public static readonly PlayerLayer SkinLongCoat = CreateVanillaLayer(nameof(SkinLongCoat), DrawPlayer_15_SkinLongCoat);
		public static readonly PlayerLayer ArmorLongCoat = CreateVanillaLayer(nameof(ArmorLongCoat), DrawPlayer_16_ArmorLongCoat);
		public static readonly PlayerLayer Torso = CreateVanillaLayer(nameof(Torso), DrawPlayer_17_Torso);
		public static readonly PlayerLayer OffhandAcc = CreateVanillaLayer(nameof(OffhandAcc), DrawPlayer_18_OffhandAcc);
		public static readonly PlayerLayer WaistAcc = CreateVanillaLayer(nameof(WaistAcc), DrawPlayer_19_WaistAcc);
		public static readonly PlayerLayer NeckAcc = CreateVanillaLayer(nameof(NeckAcc), DrawPlayer_20_NeckAcc);
		public static readonly PlayerLayer Head = CreateVanillaLayer(nameof(Head), DrawPlayer_21_Head);
		public static readonly PlayerLayer FaceAcc = CreateVanillaLayer(nameof(FaceAcc), DrawPlayer_22_FaceAcc);
		public static readonly PlayerLayer FrontAcc = CreateVanillaLayer(nameof(FrontAcc), DrawPlayer_32_FrontAcc);
		public static readonly PlayerLayer MountFront = CreateVanillaLayer(nameof(MountFront), DrawPlayer_23_MountFront);
		public static readonly PlayerLayer Pulley = CreateVanillaLayer(nameof(Pulley), DrawPlayer_24_Pulley);
		public static readonly PlayerLayer Shield = CreateVanillaLayer(nameof(Shield), DrawPlayer_25_Shield);
		public static readonly PlayerLayer SolarShield = CreateVanillaLayer(nameof(SolarShield), DrawPlayer_26_SolarShield);
		public static readonly PlayerLayer ArmOverItem = CreateVanillaLayer(nameof(ArmOverItem), DrawPlayer_28_ArmOverItem);
		public static readonly PlayerLayer OnhandAcc = CreateVanillaLayer(nameof(OnhandAcc), DrawPlayer_29_OnhandAcc);
		public static readonly PlayerLayer BladedGlove = CreateVanillaLayer(nameof(BladedGlove), DrawPlayer_30_BladedGlove);
		public static readonly PlayerLayer ProjectileOverArm = CreateVanillaLayer(nameof(ProjectileOverArm), DrawPlayer_31_ProjectileOverArm);
		public static readonly PlayerLayer FrozenOrWebbedDebuff = CreateVanillaLayer(nameof(FrozenOrWebbedDebuff), DrawPlayer_33_FrozenOrWebbedDebuff);
		public static readonly PlayerLayer ElectrifiedDebuffFront = CreateVanillaLayer(nameof(ElectrifiedDebuffFront), DrawPlayer_34_ElectrifiedDebuffFront);
		public static readonly PlayerLayer IceBarrier = CreateVanillaLayer(nameof(IceBarrier), DrawPlayer_35_IceBarrier);
		public static readonly PlayerLayer CaptureTheGem = CreateVanillaLayer(nameof(CaptureTheGem), DrawPlayer_36_CTG);
		public static readonly PlayerLayer BeetleBuff = CreateVanillaLayer(nameof(BeetleBuff), DrawPlayer_37_BeetleBuff);

		/// <summary>
		/// Creates a PlayerLayer with the given mod name, identifier name, and drawing action.
		/// </summary>
		public PlayerLayer(string mod, string name, LayerFunction layer)
			: base(mod, name, layer) {
		}

		/// <summary>
		/// Creates a PlayerLayer with the given mod name, identifier name, parent layer, and drawing action.
		/// </summary>
		public PlayerLayer(string mod, string name, PlayerLayer parent, LayerFunction layer)
			: base(mod, name, parent, layer) {
		}

		private static PlayerLayer CreateVanillaLayer(string name, LayerFunction layer) => new PlayerLayer("Terraria", name, layer);
	}
}
