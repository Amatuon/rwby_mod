using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace rwby_mod.Tiles
{
    public class GlyphSpeedTileHorizontal : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 18 };
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.addTile(Type);
            disableSmartCursor = true;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 16, 32, mod.ItemType("GlyphSpeedHorizontal"));
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            Huntsman_Player modPlayer = Main.player[Main.myPlayer].GetModPlayer<Huntsman_Player>(mod);
            Player player = Main.player[Main.myPlayer];
            if ((player.position.X / 16 <= i + 5) && (player.position.X / 16 >= i - 5) && 
                (player.position.Y / 16 <= j + 2) && (player.position.Y / 16 >= j - 2) &&
                !(modPlayer.glyphInhibitor))
            {
                if (player.velocity.X > 0.0f)
                {
                    player.velocity.X += 1.0f;
                }
                if (player.velocity.X < 0.0f)
                {
                    player.velocity.X -= 1.0f;
                }
            }
        }
    }
}
