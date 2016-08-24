using Terraria.ModLoader;

namespace rwby_mod.Items.Dusts
{
    public class DustAir : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Air Dust";
            item.width = 26;
            item.height = 20;
            item.maxStack = 999;
            AddTooltip("Happy \"Winds-day\"");
            item.value = 100;
            item.rare = 1;
        }
    }
}