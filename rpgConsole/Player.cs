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
        internal int lvl, exp = 0, def;
        public Player(string name, int hp, int def, int dmg, int lvl)
        {
            this.name = name;
            this.hp = hp;
            this.def = def;
            this.dmg = dmg;
            this.lvl = lvl;
            StartItems();

        }
        public void addExp(int exp)
        {
            this.exp += exp;
            if ((Math.Pow(lvl, 2) + (6 * lvl)) <= this.exp)
            {
                lvl++;
                this.exp = this.exp - exp;
            }
        }

        public int getDmg() { return this.dmg + weapon.itemValue; }
        public int getDef() { return this.def + armour.itemValue; }

        public string getInfo()
        {
           return("Hráč : \t" + name + Environment.NewLine + "Hp: \t\t" + hp + Environment.NewLine + "Def: \t\t" + def + Environment.NewLine + "Dmg: \t\t" + dmg + Environment.NewLine + "Exp: \t\t" + exp + Environment.NewLine + "Lvl: \t\t" + lvl + Environment.NewLine + Environment.NewLine + "Zbraň: \t" + weapon.getDetails() + Environment.NewLine + "Brnění: " + armour.getDetails());
        }

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
