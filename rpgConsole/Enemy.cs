using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    class Enemy : Entity
    {
        //Item drop;
        public Enemy(string name, int hp, int dmg)
        {
            this.name = name;
            this.hp = hp;
            this.dmg = dmg;
        }

    }
}
