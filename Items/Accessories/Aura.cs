using Terraria;
using Terraria.ID;
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
            const int manaLoss = 4;
            Huntsman_Player modPlayer = Main.player[Main.myPlayer].GetModPlayer<Huntsman_Player>(mod);

            //Handles Aura
            if (player.statMana >= (player.statManaMax / 4))
            {
                modPlayer.canRegen = true;
            }
            if (player.statMana == 0)
            {
                modPlayer.canRegen = false;
            }
            
            if ((player.statLife < player.statLifeMax) && (player.statMana >= manaLoss) && (modPlayer.canRegen == true))
            {
                player.statMana -= manaLoss;
                player.statLife += 1;
            }

            //Handles GlyphSpeed
            if (modPlayer.glyphSpeedBuff == true)
            {
                player.AddBuff(BuffID.Swiftness, 600);
                modPlayer.glyphSpeedBuff = false;
            }
        }
	}
}