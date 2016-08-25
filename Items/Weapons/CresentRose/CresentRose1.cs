using System.Collections.Generic;
using Terraria.ModLoader;

namespace rwby_mod.Items.Weapons.CresentRose
{
    public class CresentRose1 : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Cresent Rose";
            item.width = 60;
            item.height = 56;
            item.maxStack = 1;
            item.value = 100;
            item.rare = 1;
        }

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "rwby_mod/Items/Weapons/CresentRose/CresentRoseMelee";
            return true;
        }
    }
}
