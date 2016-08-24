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

        public bool canRegen = false;

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            const int manaLoss = 4;
            
            if (player.statMana >= (player.statManaMax / 4))
            {
                canRegen = true;
            }
            if (player.statMana == 0)
            {
                canRegen = false;
            }
            
            if ((player.statLife < player.statLifeMax) && (player.statMana >= manaLoss) && (canRegen == true))
            {
                player.statMana -= manaLoss;
                player.statLife += 1;
            }
        }
	}
}