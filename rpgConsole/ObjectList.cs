using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    class ObjectList
    {

        internal List<Item> Armours = new List<Item>();
        internal Dictionary<int, string> ArmoursD = new Dictionary<int, string>(); 

        internal List<Item> Swords = new List<Item>();
        internal Dictionary<int, string> SwordsD = new Dictionary<int, string>(); 

        internal List<Enemy> Enemies;

        private Random rng = new Random();

        public ObjectList()
        {
            generateItems();
            generateDesc();
        }
        private void generateItems()
        {
            
            //generate leather armors
            Armours.Add(createItem(Global.ItemType.armour, "kožené brnění", 1));
            // generate copper armors
            Armours.Add(createItem(Global.ItemType.armour, "měděné brnění", 3));
            // generate bronze armors
            Armours.Add(createItem(Global.ItemType.armour, "bronzové brnění", 5));
            // generate iron armors
            Armours.Add(createItem(Global.ItemType.armour, "železné brnění", 10));
            // generate Steel armors
            Armours.Add(createItem(Global.ItemType.armour, "Ocelové brnění", 17));


            // generate training sword
            Swords.Add(createItem(Global.ItemType.weapon, "tréningový meč", 1));
            // generate copper sword
            Swords.Add(createItem(Global.ItemType.weapon, "měděný meč", 3));
            // generate bronze sword
            Swords.Add(createItem(Global.ItemType.weapon, "bronzový meč", 5));
            // generate iron sword
            Swords.Add(createItem(Global.ItemType.weapon, "železný meč", 10));
            // generate Steel sword
            Swords.Add(createItem(Global.ItemType.weapon, "ovelový meč", 17));


        }
        private void generateDesc()
        {
            int index = 0, index2 = 0;

            foreach(Item i in Swords)
            {
                SwordsD.Add(index++, i.name);
            }
            foreach(Item i in Armours)
            {
                ArmoursD.Add(index2++, i.name);
            }
        }

        internal void printDecs(Global.ItemType itemType)
        {
            if(itemType == Global.ItemType.weapon)
            {
                foreach (var pair in SwordsD)
                {
                    Console.Write("{0}\t {1}", pair.Key, pair.Value);
                    Console.WriteLine("\t\t" + Swords[pair.Key].price + "g");
                }
            }
            else
            {
                foreach (var pair in ArmoursD)
                {
                    Console.Write("{0}\t {1}", pair.Key, pair.Value);
                }
            }
        }

        private Item createItem(Global.ItemType itemType, string itemName, int itemValue)
        {
            return new Item(itemName, itemValue + (rng.Next(1, 3) * itemValue), itemValue, itemType);
        }
    }
}
