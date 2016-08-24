using Terraria.ModLoader;

namespace rwby_mod.Items
{
    public class Gold_Platinum : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Gold or Platinum";
            item.width = 26;
            item.height = 20;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 1;
        }
    }
}