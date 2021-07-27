using Terraria.ID;
using Terraria.ModLoader;

namespace ShrekLand.Items
{
	public class ShrekSlasher : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("ShrekSlasher"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is what Ogres use in battle.");
		}

		public override void SetDefaults() 
		{
			item.damage = 99999;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 20;
			item.value = 9999999;
			item.rare = 13;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 196;
                        item.shoot = 503;
			item.shootSpeed = 8f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}