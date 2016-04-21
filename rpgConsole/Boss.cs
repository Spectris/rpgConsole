using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    class Boss : Enemy
    {
        public Boss(string name, int hp, int dmg, Item drop):base(name, hp, dmg)
        {

        }
    }
}
