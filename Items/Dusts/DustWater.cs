using Terraria.ModLoader;

namespace rwby_mod.Items.Dusts
{
    public class DustWater : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Water Dust";
            item.width = 26;
            item.height = 20;
            item.maxStack = 999;
            AddTooltip("Go with the Flow");
            item.value = 100;
            item.rare = 1;
        }
    }
}