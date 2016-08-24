using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rwby_mod.Items.Weapons.CresentRose
{
    public class CresentRose2 : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Cresent Rose";
            item.damage = 40;
            item.melee = true;
            item.width = 56;
            item.height = 56;
            item.toolTip = "Its also a gun";
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = 10000;
            item.rare = 2;
            item.useSound = 1;
            item.autoReuse = true;
            item.useTurn = true;
            item.useAmmo = ProjectileID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddIngredient(ItemID.GoldenKey, 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 10);
            recipe.AddIngredient(mod, "CresentRose1", 1);
            recipe.AddTile(TileID.Hellforge);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "rwby_mod/Items/Weapons/CresentRose/CresentRose";
            return true;
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)      //Binds to Right Click
            {
                item.melee = false;
                item.noMelee = false;
                item.ranged = true;
                item.useTime = 25;
                item.useAnimation = 25;
                item.useStyle = 5;
                item.damage = 35;
                item.useSound = 11;
                item.shoot = 10;            //Apperently all Vanilla guns have this value
                item.shootSpeed = 16f;
                item.toolTip = "Its also a Scythe";
            }

            else
            {
                item.melee = true;
                item.noMelee = false;
                item.ranged = false;
                item.useStyle = 1;
                item.useTime = 15;
                item.useAnimation = 15;
                item.damage = 40;
                item.useSound = 1;
                item.shoot = 0;
                item.toolTip = "Its also a gun";
            }

            return true;

        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(3) == 0)
            {
                if (player.altFunctionUse == 2)      //Add this effect when using right click
                {
                    int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 169, 0f, 0f, 100, default(Color), 2f);    //Creates Particle Effects
                    Main.dust[dust].noGravity = true;
                    Main.dust[dust].velocity.X += player.direction * 2f;
                    Main.dust[dust].velocity.Y += 0.2f;
                }
                else                                //Add this effect on left click
                {
                    int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Fire, player.velocity.X * 0.2f + (float)(player.direction * 3), player.velocity.Y * 0.2f, 100, default(Color), 2.5f);
                    Main.dust[dust].noGravity = true;
                }
            }
        }
    }
}