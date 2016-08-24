using Terraria.ModLoader;

namespace rwby_mod.Items.Dusts
{
    public class DustFire : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Fire Dust";
            item.width = 26;
            item.height = 20;
            item.maxStack = 999;
            AddTooltip("A Hot Commodity");
            item.value = 100;
            item.rare = 1;
        }
    }
}