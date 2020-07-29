using System;
using System.Collections.Generic;

namespace Terraria.ModLoader
{
	/// <summary> This class represents a layer of the drawing of an object, using a certain type of InfoType to help with its drawing. </summary>
	/// <typeparam name="InfoType"></typeparam>
	public abstract class DrawLayer<InfoType> : ModType
	{
		/// <summary> The delegate used for draw layers. </summary>
		public delegate void LayerFunction(ref InfoType info);

		/// <summary> The parent of this DrawLayer. If the parent is not drawn, this layer will not be drawn either. Defaults to null, which skips the parent check.</summary>
		public DrawLayer<InfoType> Parent { get; protected set; }

		/// <summary> Whether or not this DrawLayer should be drawn. For vanilla layers, this will be set to true before all drawing-related hooks are called. For modded layers, you must set this to true or false yourself. </summary>
		public bool visible = true;

		protected DrawLayer() {
		}

		/// <summary>
		/// Whether or not this layer should be drawn. Returns false if visible is false. If layerList is of type List<DrawLayer<InfoType>> and parent is not null, this will also return false if the parent is not drawn.
		/// </summary>
		public bool ShouldDraw<T>(IList<T> layers) where T : DrawLayer<InfoType> {
			if (!visible) {
				return false;
			}

			DrawLayer<InfoType> parentLayer = Parent;

			while (parentLayer != null) {
				if (!parentLayer.visible || !layers.Contains((T)parentLayer)) {
					return false;
				}

				parentLayer = parentLayer.Parent;
			}

			return true;
		}

		/// <summary> Invokes this DrawLayer's layer action. </summary>
		public abstract void Draw(ref InfoType drawInfo);

		/// <summary> Creates a new DrawLayer instance. </summary>
		public static T Create<T, TInfoType>(Mod mod, DrawLayer<TInfoType> parent) where T : DrawLayer<TInfoType>, new() {
			return new T() {
				Mod = mod,
				Parent = parent
			};
		}
	}
}
