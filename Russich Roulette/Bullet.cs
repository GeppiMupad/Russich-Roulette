using Russich_Roulette;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russisch_Roulette
{
    public class Bullet
    {
        public static int bullet;
        public static int bullet2;

        public static void Ammo(int magazinInput)
        {
            Random rnd = new Random();

            bullet = rnd.Next(1, magazinInput);
        }

        public static void Reload(int reloadint)
        {
            Random rnd = new Random();

            bullet2 = rnd.Next(1, reloadint);
            Player.nextplayer();

        }
    }
}



