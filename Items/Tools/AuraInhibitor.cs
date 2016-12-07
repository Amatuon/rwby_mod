using Terraria;
using Terraria.ModLoader;

namespace rwby_mod.Items.Tools
{
    public class AuraInhibitor : ModItem
	{
        public override void SetDefaults()
        {
            item.name = "Aura Inhibitor";
            item.width = 32;
            item.height = 32;
            item.value = 10;
            item.rare = 3;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 4;
            item.useSound = 4;
            item.useTurn = true;
        }

        public override void UpdateInventory(Player player)
        {
            Huntsman_Player modPlayer = Main.player[Main.myPlayer].GetModPlayer<Huntsman_Player>(mod);

            if (modPlayer.auraInhibitor == false)
            {
                item.toolTip = "Off";
            }
            else
            {
                item.toolTip = "On";
            }
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DustFire", 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            Huntsman_Player modPlayer = Main.player[Main.myPlayer].GetModPlayer<Huntsman_Player>(mod);

            if (player.altFunctionUse == 2)
            {
                modPlayer.auraInhibitor = true;
            }
            else
            {
                modPlayer.auraInhibitor = false;
            }

            return base.CanUseItem(player);
        }
    }
}