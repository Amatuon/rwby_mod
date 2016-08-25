using System;
using Terraria.ModLoader;

namespace rwby_mod.Projectiles
{
    public class GambolShroudBeam : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Gambol Shroud Beam";
            projectile.width = 32;
            projectile.height = 18;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.penetrate = 5;
            projectile.timeLeft = 300;
            projectile.light = 5f;
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }
    }
}
