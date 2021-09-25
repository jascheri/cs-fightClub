using FightClub.Enums;
using FightClub.Equiptment;

namespace FightClub
{
    class Character
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

        public Character(string name, Faction faction)
        {
            this.name = name;
            this.FACTION = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.Faction1:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = HERO_STARTING_HEALTH;
                    break;

                case Faction.Faction2:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = ENEMY_STARTING_HEALTH;
                    break;

                default:
                    break;
            }
        }

        public void Attack(Character target)
        {
            int damage = weapon.Damage / target.armor.ArmorPoints;

            target.health -= damage;

            if (target.health <= 0)
            {
                target.isAlive = false;
                System.Console.WriteLine($"{target.name} is dead! {name} is the victor");
            }
        }
    }


}
