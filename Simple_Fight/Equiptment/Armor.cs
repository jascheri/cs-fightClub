using FightClub.Enums;

namespace FightClub.Equiptment
{
    class Armor
    {
        private const int HERO_AP = 5;
        private const int ENEMY_AP = 5;

        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }

           
        }
        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.Hero:
                    armorPoints = HERO_AP;
                    break;
                case Faction.Enemy:
                    armorPoints = ENEMY_AP;
                    break;
                default:
                    break;
            }
        }
    }
}
