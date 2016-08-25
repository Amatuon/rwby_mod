using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rwby_mod.Items.Weapons.EmberCelica
{
    public class EmberCelicaRanged1 : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Ember Celica";
            item.toolTip = "Shotgun Gauntlets";
            item.damage = 20;
            item.ranged = true;
            item.width = 29;
            item.height = 15;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.knockBack = 5;
            item.value = 10000;
            item.rare = 2;
            item.useSound = 1;
            item.autoReuse = true;
            item.useTurn = true;
            item.shoot = ProjectileID.RocketI;
            item.shootSpeed = 15f;
            item.useAmmo = ItemID.RocketI;
        }

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "rwby_mod/Items/Weapons/EmberCelica/EmberCelica";
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

                player.QuickSpawnItem(mod.ItemType("EmberCelicaMelee1"));
            }

            else
            {

            }

            return base.CanUseItem(player);

        }
    }
}
