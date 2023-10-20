using Russisch_Roulette;
using System.Numerics;

namespace Russich_Roulette
{
    internal class Program
    {

        public static int playerindex;
        public static List<string> playerIndexL = new List<string>();

        public static string nameInput;

        public static string test;   //um 0 slot in liste zu besetzen | könnte Random bullet auch zwischen 0 und magazincapacity aussuchen lassen
        public static int testint;
        public static int loading = 4;

      //  public static int magazinInput;

        static void Main(string[] args)
        {
            Player.playerL.Add(test);  // ich lasse das aber so damit der magazinInput Sinn ergibt 
            Menu();
            Magazincapacity();


            Player.Shoot();
            
        }

        static void Menu()
        {
            Console.WriteLine("Wie viele spieler seid ihr?");
            int.TryParse(Console.ReadLine(), out int playerindex);

            for (int i = 1; i < playerindex + 1; i++)
            {
                Console.WriteLine("Spieler" + i + " gib bitte dein Namen ein:");
                nameInput = Console.ReadLine();

                Player.playerL.Add(nameInput);
            }
        }

        public static void Magazincapacity()
        {
            // Console.WriteLine($"Wie groß soll das Magazin sein?  Muss mind. {playerindex} groß sein "); Klappt nicht , wird 0 angezeigt   | Foreach schleife ? 
            // Console.WriteLine($"Wie groß soll das Magazin sein?  Muss mind. {Bullet.playerL} groß sein "); Klappt auch nicht ??
            Console.Clear();
            Console.WriteLine($"Wie groß soll das Magazin sein? ");
            int.TryParse(Console.ReadLine(), out int magazinInput);

            testint = magazinInput;
            Bullet.Ammo(magazinInput);

            for (int i = 0; i < loading; i++)
            {
                Console.Clear();
                Console.Write("Wird berechnet");

                Console.Write(".");
                Thread.Sleep(200);

                Console.Write(".");
                Thread.Sleep(200);

                Console.Write(".");
                Thread.Sleep(200);

            }

        }

        public static void Reload()
        {
           
            Bullet.Reload(testint);

        }
    }

}



