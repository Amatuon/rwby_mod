using Terraria;
using Terraria.ModLoader;

namespace rwby_mod.Items.Placeables
{
    public class GlyphSpeed : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Speed Glyph";
            item.toolTip = "Speed Boost!";
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.consumable = true;
            item.createTile = mod.TileType("GlyphSpeedTile");
            item.maxStack = 999;
            item.rare = 2;
            item.autoReuse = true;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.HasItem(mod.ItemType("Myrtenaster1")))
                return true;
            else
                return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "DustIce", 5);
            recipe.AddIngredient(mod, "DustAir", 5);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
