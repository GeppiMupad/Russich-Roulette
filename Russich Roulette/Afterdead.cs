using Russisch_Roulette;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russich_Roulette
{
    internal class Afterdead
    {
        public static int test;
        public static int bullet2;

        public static void Continue()
        {
            Console.WriteLine("Nachladen [R] | ODER | Spiel Beenden [ESC] ");

            ConsoleKeyInfo keyinfo = Console.ReadKey();

            switch (keyinfo.Key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.R:

                    Program.Reload();
                    break;

                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
