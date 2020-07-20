using System;
using System.Collections.Generic;

namespace Terraria.ModLoader
{
	/// <summary>
	/// This class represents a layer of the drawing of an object, using a certain type of InfoType to help with its drawing.
	/// </summary>
	/// <typeparam name="InfoType"></typeparam>
	public abstract class DrawLayer<InfoType>
	{
		/// <summary>
		/// The delegate used for draw layers.
		/// </summary>
		public delegate void LayerFunction(ref InfoType info);

		/// <summary>
		/// The name of the mod to which this DrawLayer belongs.
		/// </summary>
		public readonly string Mod;
		/// <summary>
		/// The name which identifies this DrawLayer.
		/// </summary>
		public readonly string Name;
		/// <summary>
		/// The parent of this DrawLayer. If the parent is not drawn, this layer will not be drawn either. Defaults to null, which skips the parent check.
		/// </summary>
		public readonly DrawLayer<InfoType> Parent;
		/// <summary>
		/// The delegate of this method, which can either do the actual drawing or add draw data, depending on what kind of layer this is.
		/// </summary>
		public readonly LayerFunction Layer;

		/// <summary>
		/// Whether or not this DrawLayer should be drawn. For vanilla layers, this will be set to true before all drawing-related hooks are called. For modded layers, you must set this to true or false yourself.
		/// </summary>
		public bool visible = true;

		/// <summary>
		/// Creates a DrawLayer with the given mod name, identifier name, and drawing action.
		/// </summary>
		protected DrawLayer(string mod, string name, LayerFunction layer) : this(mod, name, null, layer) {
		}

		/// <summary>
		/// Creates a DrawLayer with the given mod name, identifier name, parent layer, and drawing action.
		/// </summary>
		protected DrawLayer(string mod, string name, DrawLayer<InfoType> parent, LayerFunction layer) {
			Mod = mod;
			Name = name;
			Parent = parent;
			Layer = layer;
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

		/// <summary>
		/// Invokes this DrawLayer's layer action.
		/// </summary>
		public virtual void Draw(ref InfoType drawInfo) => Layer(ref drawInfo);
	}
}
