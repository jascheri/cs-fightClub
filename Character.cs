using FightClub.Enums;
using FightClub.Equiptment;
using System;
using System.Threading;

namespace FightClub
{
    class Character
    {
        private const int HERO_STARTING_HEALTH = 100;
        private const int ENEMY_STARTING_HEALTH = 100;

        static Random rng = new Random();

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
            int damage = weapon.Damage / rng.Next(1,10) - target.armor.ArmorPoints / rng.Next(1, 10);
            if (damage < 0) damage = 0;
            target.health -= damage;
            attackResult(target, damage);
        }

        private void attackResult(Character target, int damage)
        {
            if (target.health <= 0)
            {
                target.isAlive = false;
                Tools.ColorfulWriteLine($"{target.name} is dead!", ConsoleColor.Red);
                Tools.ColorfulWriteLine($"{name} is the victor", ConsoleColor.Green);
            }
            else
            {
                Console.WriteLine($"{name} hit {target.name} for {damage} damage. {target.name} has {target.health} remaining.");
            }
            Thread.Sleep(200);
        }
    }


}
