using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace rwby_mod.Items.Weapons.GambolShroud
{
    public class GambolShroudThrown1 : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Gambol Shroud";
            item.width = 48;
            item.height = 10;
            item.toolTip = "Look its a Blade, its Gun, its a . . . Boomerang?";
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 10;
            item.noMelee = true;
            item.useStyle = 5;
            item.useAnimation = 40; 
            item.useTime = 40;
            item.knockBack = 7.5F;
            item.damage = 15;
            item.scale = 2F;
            item.noUseGraphic = false;
            item.shoot = mod.ProjectileType("GambolShroudFlail");
            item.shootSpeed = 15.1F;
            item.useSound = 1;
            item.thrown = true;
            item.channel = true;
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

                player.QuickSpawnItem(mod.ItemType("GambolShroudMelee1"));
            }

            else
            {

            }

            return base.CanUseItem(player);

        }
    }
}