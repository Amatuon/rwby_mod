using Terraria;
using Terraria.ModLoader;

namespace rwby_mod.Items.Accessories
{
    public class Aura : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Aura";
			item.width = 32;
			item.height = 32;
            item.toolTip = "The power that protects you is your own";
			item.value = 10;
			item.rare = 3;
			item.accessory = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DustFire", 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            player.AddBuff(mod.BuffType("Aura"), 5);    //5 is Duration of Buff in 1/60 seconds
        }
	}
}