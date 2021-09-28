using System;
using FightClub.Enums;
using FightClub.Equiptment;

namespace FightClub
{
    class Start
    {
        static Random rng = new Random();

        static void Main()
        {
            
            Character hero = new Character("Dan", Faction.Hero, new Weapon(1), new Armor(3));
            Character enemy = new Character("Fred", Faction.Faction1, new Weapon(5), new Armor(5));

            while (hero.IsAlive && enemy.IsAlive)
            {
                if (rng.Next(0, 10) < 5)
                {
                    hero.Attack(enemy);
                }
                else
                {
                    enemy.Attack(hero);
                }
            }
        }
    }
}
