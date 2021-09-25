﻿using System;

namespace FightClub
{
    static class Tools
    {
        public static void ColorfulWriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}