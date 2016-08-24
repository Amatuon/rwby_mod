using Terraria.ModLoader;

namespace rwby_mod.Items.Dusts
{
    public class DustIce : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Ice Dust";
            item.width = 26;
            item.height = 20;
            item.maxStack = 999;
            AddTooltip("Too Cool for you");
            item.value = 100;
            item.rare = 1;
        }
    }
}