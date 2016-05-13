using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    class Player : Entity
    {
        private Random rng = new Random();
        internal Item weapon, armour;
        internal int lvl, exp = 0, def, skillPoints = 0, money = 50;
        public Player(string name, int hp, int def, int dmg, int lvl)
        {
            this.name = name;
            this.hp = hp;
            this.def = def;
            this.dmg = dmg;
            this.lvl = lvl;
            StartItems();

        }
        public void AddExp(int addedExp)
        {
            int lvlTemp = lvl;
            int expCap = (lvl * lvl) + (6 * lvl);
            exp += addedExp;
            if (exp >= expCap )
            {
                lvl++;
                exp -= expCap;

                Console.WriteLine("Získal jsi novou úroveň! Nyní si vyber jednu ze svých vlastností, kterou vylepšíš\n\t\t(O)brana\t(Z)draví\t(U)tok\n Pokud nevybereš ani jednu z možností, vylepšení bude náhodné");
                increseStats();
            }
        }

        private void increseStats()
        {
            string key = Console.ReadLine();
            if (key == "o") def++;
            else if (key == "z") hp++;
            else if (key == "u") dmg++;
            else
            {
                switch(rng.Next(0,3))
                {
                    case 0: def++; break;
                    case 1: hp++; break;
                    case 2: dmg++; break;
                }
            }
        }

        public int GetDmg() { return dmg + weapon.itemValue; }
        public int GetDef() { return def + armour.itemValue; }

        public string GetInfo()
        {
           return("Hráč : \t" + name + Environment.NewLine + "Hp: \t\t" + hp + Environment.NewLine + "Def: \t\t" + def + Environment.NewLine + "Dmg: \t\t" + dmg + Environment.NewLine + "Exp: \t\t" + exp + Environment.NewLine + "Lvl: \t\t" + lvl + Environment.NewLine + "Money: \t\t" + money + Environment.NewLine + Environment.NewLine + "Zbraň: \t" + weapon.getDetails() + Environment.NewLine + "Brnění: " + armour.getDetails());
        }

        private void StartItems()
        {
            weapon = new Item("Dřevěný meč", 1, 1, Global.ItemType.weapon);
            armour = new Item("Kožené brnění", 5, 1, Global.ItemType.armour);
        }

        public void GodMode()
        {
            weapon = new Item("Božský měc", 0, 1000, Global.ItemType.weapon);
            armour = new Item("Božské brnění", 0, 1000, Global.ItemType.armour);
        }

    }
}
