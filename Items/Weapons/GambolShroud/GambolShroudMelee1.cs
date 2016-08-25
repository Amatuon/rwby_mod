using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rwby_mod.Items.Weapons.GambolShroud
{
    public class GambolShroudMelee1 : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Gambol Shroud";
            item.damage = 15;
            item.melee = true;
            item.width = 29;
            item.height = 15;
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
            item.shoot = mod.ProjectileType("GambolShroudBeam");
            item.shootSpeed = 8f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 10);
            recipe.AddRecipeGroup("rwby_mod:Gold_Platinum", 4);
            recipe.AddIngredient(mod, "DustSteam", 15);
            recipe.AddTile(TileID.Furnaces);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
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

                player.QuickSpawnItem(mod.ItemType("GambolShroudRanged1"));
            }

            else
            {

            }

            return base.CanUseItem(player);

        }
    }
}