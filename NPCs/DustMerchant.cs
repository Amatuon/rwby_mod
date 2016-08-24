using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rwby_mod.NPCs
{
    public class DustMerchant : ModNPC
	{
        public override bool Autoload(ref string name, ref string texture, ref string[] altTextures)
        {
            name = "Dust Merchant";
            altTextures = null;
            return mod.Properties.Autoload;
        }

        public override void SetDefaults()
		{
			npc.name = "Dust Merchant";
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;            //7 = Passive ai aka what the townmembers have
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.soundHit = 1;
			npc.soundKilled = 1;
			npc.knockBackResist = 0.5f;
			Main.npcFrameCount[npc.type] = 25;
			animationType = NPCID.Merchant;
		}
		
		public override bool CanTownNPCSpawn(int numTownNPCs, int money)
		{
			return NPC.savedAngler;             //Should mean you have to find the Angler First
		}
		
		public override string TownNPCName()	//Create a list of possible names
		{
			switch (WorldGen.genRand.Next(4))
			{
				case 0:
					return "Joe";
				case 1:
					return "Dom";
				case 2:
					return "Matt";
				default:
					return "Andrew";
			}
		}
		
		public override string GetChat()	//Chat Options
		{
			switch (Main.rand.Next(3))
			{
				case 0:
					return "I ain't scared of no Grimm!";
				case 1:
					return "I wish someone would pay in Lien.";
				default:
					return "Dust for Sale!";
			}
		}
		
		public override void SetChatButtons(ref string button, ref string button2)
		{
			button = Lang.inter[28];
		}
		
		public override void OnChatButtonClicked(bool firstButton, ref bool shop)
		{
			if (firstButton)
				{
					shop = true;
				}
		}
		
		public override void SetupShop(Chest shop, ref int nextSlot)
		{
			shop.item[nextSlot].SetDefaults(mod.ItemType("DustAir"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("DustEarth"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("DustFire"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("DustWater"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("DustGravity"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("DustIce"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("DustSteam"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("DustLightning"));
        }
    }
}