using Terraria.ModLoader;

namespace rwby_mod.Items.Dusts
{
    public class DustEarth : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Earth Dust";
            item.width = 26;
            item.height = 20;
            item.maxStack = 999;
            AddTooltip("It needs a big wide sounding name");
            AddTooltip2("like * ow * ound * round * ground!");
            item.value = 100;
            item.rare = 1;
        }
    }
}