using System;
using FightClub.Enums;

namespace FightClub
{
    class Start
    {
        static Random rng = new Random();

        static void Main()
        {
            Character hero = new Character("Dan", Faction.Faction1);
            Character enemy = new Character("Fred", Faction.Faction2);

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
