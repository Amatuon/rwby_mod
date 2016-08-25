using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rwby_mod.Items.Weapons.GambolShroud
{
    public class GambolShroudRanged1 : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Gambol Shroud";
            item.damage = 15;
            item.ranged = true;
            item.noMelee = true;
            item.width = 48;
            item.height = 10;
            item.toolTip = "Look its a Blade, its Gun, its a . . . Boomerang?";
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = 10000;
            item.rare = 2;
            item.useSound = 1;
            item.autoReuse = true;
            item.useTurn = true;
            item.shoot = 10;
            item.shootSpeed = 16f;
            item.useAmmo = ProjectileID.Bullet;
        }

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "rwby_mod/Items/Weapons/GambolShroud/GambolShroudMelee";
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

                player.QuickSpawnItem(mod.ItemType("GambolShroudThrown1"));
            }

            else
            {

            }

            return base.CanUseItem(player);

        }
    }
}
