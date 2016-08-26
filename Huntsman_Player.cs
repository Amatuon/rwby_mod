using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace rwby_mod
{
    public class Huntsman_Player : ModPlayer
    {
        public bool canRegen = false;
        public bool glyphSpeedBuff = false;

        public override void PreUpdateBuffs()
        {
            //player.AddBuff(BuffID.Swiftness, 600);
        }
    }
}
