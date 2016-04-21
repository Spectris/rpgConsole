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
        internal int lvl, exp = 0, def, skillPoints = 0;
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

                Console.WriteLine("Získal jsi novou úroveň, nyní si vyber kterou ze svých vlastností vylepšíš\n\t\t(O)brana\t(Z)draví\t(U)tok\n Pokud nespecifikuješ která vlastnost, kterou chceš zvýšit, bude vybráno náhodně");
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

        public int GetDmg() { return this.dmg + weapon.itemValue; }
        public int GetDef() { return this.def + armour.itemValue; }

        public string GetInfo()
        {
           return("Hráč : \t" + name + Environment.NewLine + "Hp: \t\t" + hp + Environment.NewLine + "Def: \t\t" + def + Environment.NewLine + "Dmg: \t\t" + dmg + Environment.NewLine + "Exp: \t\t" + exp + Environment.NewLine + "Lvl: \t\t" + lvl + Environment.NewLine + Environment.NewLine + "Zbraň: \t" + weapon.getDetails() + Environment.NewLine + "Brnění: " + armour.getDetails());
        }

        private void StartItems()
        {
            weapon = new Item("Dreveny mec", 1, 1, ItemType.weapon);
            armour = new Item("Kozene brneny", 5, 1, ItemType.armour);
        }

        public void GodMode()
        {
            weapon = new Item("Gods Sword", 0, 1000, ItemType.weapon);
        }

    }
}
