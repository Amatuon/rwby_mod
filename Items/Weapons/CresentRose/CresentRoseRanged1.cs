using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rwby_mod.Items.Weapons.CresentRose
{
    public class CresentRoseRanged1 : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Cresent Rose";
            item.damage = 15;
            item.ranged = true;
            item.noMelee = true;
            item.width = 75;
            item.height = 50;
            item.toolTip = "Its also a Scythe";
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.knockBack = 5;
            item.value = 10000;
            item.rare = 0;
            item.useSound = 11;
            item.autoReuse = true;
            item.useTurn = true;
            item.shoot = 10;
            item.shootSpeed = 16f;
            item.useAmmo = ProjectileID.Bullet;
        }

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "rwby_mod/Items/Weapons/CresentRose/CresentRoseRanged";
            return true;
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.stack -= 1;

                if (item.stack == 0)
                    item.type = 0;

                player.QuickSpawnItem(mod.ItemType("CresentRoseMelee1"));
            }

            else
            {

            }

            return base.CanUseItem(player);

        }
    }
}
