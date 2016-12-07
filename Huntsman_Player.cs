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
        public bool auraInhibitor = false;
        public bool glyphInhibitor = false;

        public override void PreUpdateBuffs()
        {
            if (auraInhibitor == false)
            {
                player.AddBuff(mod.BuffType("Aura"), 5);    //5 is Duration of Buff in 1/60 seconds
            }
        }
    }
}
