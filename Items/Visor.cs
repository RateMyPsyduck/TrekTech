using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace TrekTech.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class Visor : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Reading the spectral Rainbow.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 3;

            ArmorIDs.Head.Sets.DrawFullHair[Item.headSlot] = true;
		}

		public override void SetDefaults() {
			Item.width = 15; 
			Item.height = 4; 
			Item.rare = ItemRarityID.Pink; 
			Item.defense = 1; 
		}

		public override void UpdateEquip(Player player) {
            player.AddBuff(12, 2);
            player.AddBuff(9, 2);
            player.AddBuff(17, 2);
            player.AddBuff(111, 2);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddTile<Items.replicator>();
			recipe.Register();
		}
	}
}
