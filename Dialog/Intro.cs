using System;
using System.Collections.Generic;
using System.Text;

namespace FightClub.Dialog
{
    class Intro
    {
        public Character Landing()
        {
            Tools.Write("Welcome to the game...");
            Tools.Write("We'll Make this quick...");
            Tools.Write("What is your name?");

            String name = (string)Console.ReadLine();

            Tools.Write($"Nice to Meet you {name}. You are being given a shiny new Sword to use to vanquish your foe.");
            Tools.Write("Now go kill the dude...");

            return new Character(name, Enums.Faction.Hero, new Equiptment.Weapon(1), new Equiptment.Armor(1));  
        }
    }
}
