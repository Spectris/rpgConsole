using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    class Enemy : Entity
    {
        internal string plural;
        public Enemy(string name, int hp, int dmg)
        {
            this.name = name;
            this.hp = hp;
            this.dmg = dmg;
        }
        public Enemy(string name, string plural, int hp, int dmg)
        {
            this.name = name;
            this.plural = plural;
            this.hp = hp;
            this.dmg = dmg;
        }

    }
}
