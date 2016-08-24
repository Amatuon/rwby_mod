using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rwby_mod.Items.Weapons.EmberCelica
{
    public class EmberCelica1 : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Ember Celica";
            item.toolTip = "Shotgun Guantlets";
            item.width = 29;
            item.height = 15;
            item.melee = true;
            item.damage = 20;
            item.useTime = 12;
            item.useStyle = 5;
            item.useAnimation = 12;
            item.useSound = 10;
            item.useTurn = true;
            item.autoReuse = true;
            item.knockBack = 3;
            item.value = 1;
            item.rare = 1;
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

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)      //Binds to Right Click
            {
                item.melee = false;
                item.ranged = true;
                item.toolTip = "rightclicked";
              //item.shoot = ItemID.RocketI;
            }

            else
            {
                item.melee = true;
                item.ranged = false;
                item.toolTip = "Left clickes";
                item.shoot = mod.ProjectileType("EmberCelicaBlast");
                item.shootSpeed = 1f;
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
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return true;
        }
    }
}
