using System;
using System.Threading;

namespace FightClub
{
    static class Tools
    {
        public static void ColorfulWriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Write(text);
            Console.ResetColor();
        }

        public static void Write (string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
               // Thread.Sleep(5);
            }
            Console.Write("\n");
        }
    }
}
