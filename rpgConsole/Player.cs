using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    class Player : Entity
    {
        internal Item weapon, armour;
        internal int lvl, exp, def;
        public Player(string name, int hp, int def, int dmg, int lvl)
        {
            this.name = name;
            this.hp = hp;
            this.def = def;
            this.dmg = dmg;
            this.lvl = lvl;

        }
        public void addLvl()
        {

        }
        public int getDmg() { return this.dmg + weapon.itemValue; }
        public int getDef() { return this.def + armour.itemValue; }

        private void StartItems()
        {
            weapon = new Item("dreveny mec", 1, 1, ItemType.weapon);
            armour = new Item("Kozene brneny", 5, 1, ItemType.armour);
        }
        public void godMode()
        {
            weapon = new Item("God Sword", 0, 1000, ItemType.weapon);
            armour = new Item("God armour", 0, 1000, ItemType.armour);
        }

    }
}
