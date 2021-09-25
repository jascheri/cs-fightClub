using FightClub.Enums;

namespace FightClub.Equiptment
{
    class Weapon
    {
        private const int HERO_DAMAGE = 5;
        private const int ENEMY_DAMAGE = 5;

        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
        }
        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.Faction1:
                    damage = HERO_DAMAGE;
                    break;
                case Faction.Faction2:
                    damage = ENEMY_DAMAGE;
                    break;
                default:
                    break;
            }
        }
    }
}
