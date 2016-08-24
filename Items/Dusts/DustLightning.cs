using Terraria.ModLoader;

namespace rwby_mod.Items.Dusts
{
    public class DustLightning : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Lightning Dust";
            item.width = 26;
            item.height = 20;
            item.maxStack = 999;
            AddTooltip("Shocking!  I Love it Lightning!");
            AddTooltip2("You've been Thunderstruck!");
            item.value = 100;
            item.rare = 1;
        }
    }
}