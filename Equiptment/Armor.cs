using FightClub.Enums;
using System;

namespace FightClub.Equiptment
{
    class Armor : Equiptment
    {

        public int ArmorPoints { get; set; }

        static Random rng = new Random();
        /// <summary>
        /// Creates an armor for the character
        /// </summary>
        /// <param name="level">
        /// Armor level to be set
        /// </param>
        public Armor(int level)
        {
            MyLevel = level;
            SetArmor(level);
        }
        /// <summary>
        /// Calculates min and max armor points from a range based on the provided level.
        /// </summary>
        /// <param name="level">
        /// Armor's level
        /// </param>
        private void SetArmor(int level)
        {
            ArmorPoints = rng.Next(0 + level, 5 + level);
        }
    }
}
