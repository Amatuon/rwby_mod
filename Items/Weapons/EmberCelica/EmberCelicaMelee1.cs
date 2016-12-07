using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rwby_mod.Items.Weapons.EmberCelica
{
    public class EmberCelicaMelee1 : ModItem
    {
        public static byte reforge = (byte)0;
        public static byte reforgeTemp = (byte)0;
        public static bool reforgeLogic = false;

        public override void SetDefaults()
        {
            item.name = "Ember Celica";
            item.toolTip = "Shotgun Gauntlets";
            item.damage = 20;
            item.melee = true;
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
            item.shoot = mod.ProjectileType("EmberCelicaBlast");
            item.shootSpeed = 1f;
        }

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "rwby_mod/Items/Weapons/EmberCelica/EmberCelica";
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 10);
            recipe.AddRecipeGroup("rwby_mod:Gold_Platinum", 4);
            recipe.AddIngredient(mod, "DustLightning", 15);
            recipe.AddTile(TileID.Furnaces);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void PostReforge()
        {
            if (EmberCelicaMelee1.reforgeLogic == true)
            {
                item.prefix = EmberCelicaMelee1.reforge;
                EmberCelicaMelee1.reforgeLogic = false;
            }
        }
        
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                EmberCelicaMelee1.reforge = item.prefix;
                EmberCelicaMelee1.reforgeLogic = true;

                item.stack -= 1;

                if (item.stack == 0)
                    item.type = 0;

                player.QuickSpawnItem(mod.ItemType("EmberCelicaRanged1"));
            }

            else
            {

            }

            return base.CanUseItem(player);

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 5;
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f;
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }
}
