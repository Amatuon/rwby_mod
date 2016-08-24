using Terraria.ModLoader;

namespace rwby_mod.Items.Dusts
{
    public class DustSteam : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Steam Dust";
            item.width = 26;
            item.height = 20;
            item.maxStack = 999;
            AddTooltip("It dosen't download games");
            item.value = 100;
            item.rare = 1;
        }
    }
}