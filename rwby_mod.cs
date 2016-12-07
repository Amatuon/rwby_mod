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
            RecipeGroup group1 = new RecipeGroup(() => "Either Gold or Platinum", new int[]
            {
                ItemID.GoldBar,
                ItemID.PlatinumBar
            });
            RecipeGroup.RegisterGroup("rwby_mod:Gold_Platinum", group1);

            RecipeGroup group2 = new RecipeGroup(() => "Either Demonite or Crimtane", new int[]
            {
                ItemID.DemoniteBar,
                ItemID.CrimtaneBar
            });
            RecipeGroup.RegisterGroup("rwby_mod:BadMetal", group2);

            RecipeGroup group3 = new RecipeGroup(() => "Cresent Rose", new int[]    //Cresent Rose 1
            {
                ItemType("CresentRoseMelee1"),
                ItemType("CresentRoseRanged1")                
            });
            RecipeGroup.RegisterGroup("rwby_mod:CresentRose1", group3);

            RecipeGroup group4 = new RecipeGroup(() => "Cresent Rose", new int[]   //Cresent Rose 2
            {
                ItemType("CresentRoseMelee2"),
                ItemType("CresentRoseRanged2")
            });
            RecipeGroup.RegisterGroup("rwby_mod:CresentRose2", group4);
        }
    }
}
