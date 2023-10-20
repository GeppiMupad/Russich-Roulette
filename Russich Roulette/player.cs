using Russisch_Roulette;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russich_Roulette
{
    internal class Player
    {
        public static List<string> playerL = new List<string>();


        
        public static bool isAlive = true;
        
        public static int i = 0; 

        public static void Shoot()
        {                                    
            while (isAlive)     //achdem er stirb isAlive = false, deswegen wird das geskippt 
            {
                Console.Clear();
                i++;
                Console.WriteLine($"Alles Klar, {playerL[i]} Du kannst mit [ENTER] schießen :");

                Console.ReadKey();
                
                Console.Clear();
                Console.WriteLine("SCHUSS!!!");
                Console.ReadKey();
                isdead();
            }

           
        }

        
        public static void isdead()
        {

            
            if (i == Bullet.bullet)
            {
                playerL.Remove(playerL[i]); // was habe ich mir dabei gedacht ? reihenfolge geht nur durcheinander i
                               
                Console.WriteLine("Bist tot");
                
                Console.ReadKey(true);
               
                Afterdead.Continue();
            }
            else
            {
                Console.WriteLine("Lebst noch");
                Console.ReadKey(true);
                isAlive = true;
            }

            Console.Clear();
        }


        public static void nextplayer()
        {
            //playerL[i] += 1; // der nächste player wird aber dadurch geskippt 
            Shoot();
        }
    }
}
