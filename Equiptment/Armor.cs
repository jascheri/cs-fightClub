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
                case Faction.Faction1:
                    armorPoints = HERO_AP;
                    break;
                case Faction.Faction2:
                    armorPoints = ENEMY_AP;
                    break;
                default:
                    break;
            }
        }
    }
}
