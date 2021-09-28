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
        /// <summary>
        /// Dexterity Modifier for a characters armor in combat
        /// </summary>
        private const double DEX_MODIFIER = 1.2;
        public const double STR_MODIFIER = 1.5;

        private readonly Faction FACTION;

        private int health;
        private string name;
        private bool isAlive;

        // Temp Starting variables
        /// <summary>
        /// Charater's strength to be used for attacks and potential challenges in the future.
        /// </summary>
        public int Strength { get; private set; } = 1;
        /// <summary>
        /// Character's dexterity to be used for defence and potential challenges
        /// </summary>
        public double Dexterity { get; private set; } = 1;
        public int weaponStartLevel = 1;
        public int armorStartLevel = 1;
        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }


        public Weapon weapon;
        private Armor armor;
        /// <summary>
        /// A character in the game that will be fighting/questing
        /// </summary>
        /// <param name="name">Name of the character</param>
        /// <param name="faction">Faction that the character belongs to</param>
        public Character(string name, Faction faction, Weapon weapon, Armor armor)
        {
            this.name = name;
            this.FACTION = faction;
            isAlive = true;
            this.weapon = weapon;
            this.armor = armor;

            switch (FACTION)
            {
                case Faction.Hero:
                    health = HERO_STARTING_HEALTH;
                    break;

                case Faction.Faction1:
                    health = ENEMY_STARTING_HEALTH;
                    break;

                default:
                    break;
            }
        }

        public void Attack(Character target)
        {

            int hitDamage = weapon.GiveHitStat();
            int damage = (int)(hitDamage * (Strength * Character.STR_MODIFIER) - target.armor.ArmorPoints * (target.Dexterity * Character.DEX_MODIFIER));
            if (damage < 0) damage = 0;
            target.health -= damage;
            AttackResult(target, damage);
        }

        private void AttackResult(Character target, int damage)
        {
            if (target.health <= 0)
            {
                target.isAlive = false;
                Tools.ColorfulWriteLine($"{target.name} is dead!", ConsoleColor.Red);
                Tools.ColorfulWriteLine($"{name} is the victor", ConsoleColor.Green);
            }
            else
            {
                Tools.Write($"{name} hit {target.name} for {damage} damage. {target.name} has {target.health} remaining.");
            }
            Thread.Sleep(500);
        }
    }


}
