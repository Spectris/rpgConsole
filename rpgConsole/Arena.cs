using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    class Arena
    {
        private static Enemy boss1 = new Enemy("BOSS-EIN", 200, 15);
        public static void EnterArena(Player player)
        {
            Console.WriteLine(texts.ArenaEntery);

        }
    }
}
