using Terraria.ModLoader;

namespace rwby_mod.Items.Dusts
{
    public class DustGravity : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Gravity Dust";
            item.width = 26;
            item.height = 20;
            item.maxStack = 999;
            AddTooltip("Does this Dust make my Gun look Big?");
            item.value = 100;
            item.rare = 1;
        }
    }
}