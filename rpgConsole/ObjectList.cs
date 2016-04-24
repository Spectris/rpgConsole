using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    class ObjectList
    {

        internal List<Item> Armours;

        internal List<Item> Swords;

        internal List<Item> Spears;

        internal List<Enemy> Enemies;

        private Random rng = new Random();

        public ObjectList()
        {
          

        }
        private void generateItems()
        {
            
           
            // generate leather armors
            Armours.Add(createItem(ItemType.armour, "kožené brnění", 1));
            // generate copper armors
            Armours.Add(createItem(ItemType.armour, "měděné brnění", 3));
            // generate bronze armors
            Armours.Add(createItem(ItemType.armour, "bronzové brnění", 5));
            // generate iron armors
            Armours.Add(createItem(ItemType.armour, "železné brnění", 10));
            // generate Steel armors
            Armours.Add(createItem(ItemType.armour, "Ocelové brnění", 17));
            // generate adamantium armors
            Armours.Add(createItem(ItemType.armour, "adamantiové brnění", 50));


            // generate training sword
            Swords.Add(createItem(ItemType.weapon, "tréningový meč", 1));
            // generate copper sword
            Swords.Add(createItem(ItemType.weapon, "měděný meč", 3));
            // generate bronze sword
            Swords.Add(createItem(ItemType.weapon, "bronzový meč", 5));
            // generate iron sword
            Swords.Add(createItem(ItemType.weapon, "železný meč", 10));
            // generate Steel sword
            Swords.Add(createItem(ItemType.weapon, "ovelový meč", 17));
            // generate adamantium sword
            Swords.Add(createItem(ItemType.weapon, "adamantiový meč", 50));


        }


        private Item createItem(ItemType itemType, string itemName, int itemValue)
        {
            return new Item(itemName, itemValue + (rng.Next(1, 3) * itemValue), itemValue, itemType);
        }
    }
}
