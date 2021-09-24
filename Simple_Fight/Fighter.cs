using FightClub.Enums;
using FightClub.Equiptment;

namespace FightClub
{
    class Fighter
    {
        private const int HERO_STARTING_HEALTH = 100;
        private const int ENEMY_STARTING_HEALTH = 100;

        private readonly Faction FACTION;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        private Weapon weapon;
        private Armor armor;

        public Fighter(string name, Faction faction)
        {
            this.name = name;
            this.FACTION = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.Hero:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = HERO_STARTING_HEALTH;
                    break;

                case Faction.Enemy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = ENEMY_STARTING_HEALTH;
                    break;

                default:
                    break;
            }
        }
    }

  
}
