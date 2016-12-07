using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rwby_mod.Items.Tools
{
    class GlyphInhibitor : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Glyph Protection";
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

            if (modPlayer.glyphInhibitor == false)
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
                modPlayer.glyphInhibitor = true;
            }
            else
            {
                modPlayer.glyphInhibitor = false;
            }

            return base.CanUseItem(player);
        }
    }
}
