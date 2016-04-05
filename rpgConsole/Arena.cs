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
        public void EnterArena()
        {
            Console.WriteLine(texts.ArenaEntery);

        }
    }
}
