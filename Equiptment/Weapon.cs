using FightClub.Enums;
using System;

namespace FightClub.Equiptment
{
    class Weapon : Equiptment
    {

        private int[] damageRange = new int[2];

        static readonly Random rng = new Random();

        /// <summary>
        /// Creates a weapon for the character
        /// </summary>
        /// <param name="level">
        /// Weapon level to be set
        /// </param>
        public Weapon(int level)
        {
            MyLevel = level;
            SetDamage(level);
        }
        /// <summary>
        /// Calculates min and max damage from a range based on the provided level.
        /// </summary>
        /// <param name="level">
        /// Weapon's level
        /// </param>
        private void SetDamage(int level)
        {
            damageRange[0] = rng.Next(0 + level, 5 + level);
            damageRange[1] = rng.Next(damageRange[0], 10 + level);
        }

        public int GiveHitStat()
        {
            return rng.Next(damageRange[0], damageRange[1]);
        }
    }
}
