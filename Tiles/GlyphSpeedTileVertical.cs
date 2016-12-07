using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace rwby_mod.Tiles
{
    class GlyphSpeedTileVertical : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.Origin = new Point16(1, 2);
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 18 };
            TileObjectData.addTile(Type);
            disableSmartCursor = true;
            Main.tileLavaDeath[Type] = true;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 48, mod.ItemType("GlyphSpeedVertical"));
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            Huntsman_Player modPlayer = Main.player[Main.myPlayer].GetModPlayer<Huntsman_Player>(mod);
            Player player = Main.player[Main.myPlayer];
            if ((player.position.X / 16 <= i + 2) && (player.position.X / 16 >= i - 2) &&
                (player.position.Y / 16 <= j + 5) && (player.position.Y / 16 <= j - 5) &&
                !(modPlayer.glyphInhibitor))
            {
                if (player.velocity.Y > 0.0f)
                {
                    player.velocity.Y += 1.0f;
                }
                else if (player.velocity.Y < 0.0f)
                {
                    player.velocity.Y -= 1.0f;
                }
            }
        }
    }
}
