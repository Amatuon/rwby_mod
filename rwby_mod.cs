using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rwby_mod
{
    public class rwby_mod : Mod
    {
        public rwby_mod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }

        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " " + GetItem("Gold_Platinum").item.name, new int[]
            {
                ItemType("Gold_Platinum"),
                ItemID.GoldBar,
                ItemID.PlatinumBar
            });
            RecipeGroup.RegisterGroup("rwby_mod:Gold_Platinum", group);
        }
    }
}
