using Terraria.GameContent.UI;
using Terraria.ModLoader;
using Terraria;
using TrekTech.Items;
using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Shaders;
using Terraria.Graphics.Effects;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;


namespace TrekTech
{

	public partial class TrekTech : Mod
	{
		public static ModKeybind beamKey;
		public static ModKeybind UIKey;

		public override void Load() {
			beamKey = KeybindLoader.RegisterKeybind(this, "Beam to Set Location", "L");
			UIKey = KeybindLoader.RegisterKeybind(this, "Bring Up PADD", "P");
		}

		public override void Unload() {
			beamKey = null;
			UIKey = null;
		}
	}
}
