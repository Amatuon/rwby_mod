using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rwby_mod.Buffs
{
    public class Aura : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffName[this.Type] = "Aura";
            Main.buffTip[this.Type] = "Its like a Force Field!";
        }

        public override void Update(Player player, ref int buffIndex)
        {
            const int manaLoss = 4;
            Huntsman_Player modPlayer = Main.player[Main.myPlayer].GetModPlayer<Huntsman_Player>(mod);

            if (player.statMana >= (player.statManaMax / 4))
            {
                modPlayer.canRegen = true;
            }
            if (player.statMana == 0)
            {
                modPlayer.canRegen = false;
            }

            if ((player.statLife < player.statLifeMax) && (player.statMana >= manaLoss) && (modPlayer.canRegen == true))
            {
                player.statMana -= manaLoss;
                player.statLife += 1;
            }
        }
    }
}
