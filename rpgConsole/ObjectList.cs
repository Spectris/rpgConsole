using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    internal class ObjectList
    {

        internal List<Item> Armours = new List<Item>(); 

        internal List<Item> Swords = new List<Item>();

        internal List<string> enemyNames = new List<string>();


        internal ObjectList()
        {
            generateItems();
            generateEnemyNames();
        }
        private void generateItems()
        {
            
            // generate copper armors
            Armours.Add(createItem(Global.ItemType.armour, "měděné brnění", 3));
            // generate bronze armors
            Armours.Add(createItem(Global.ItemType.armour, "bronzové brnění", 5));
            // generate iron armors
            Armours.Add(createItem(Global.ItemType.armour, "železné brnění", 10));
            // generate Steel armors
            Armours.Add(createItem(Global.ItemType.armour, "Ocelové brnění", 17));


            // generate copper sword
            Swords.Add(createItem(Global.ItemType.weapon, "měděný meč", 3));
            // generate bronze sword
            Swords.Add(createItem(Global.ItemType.weapon, "bronzový meč", 5));
            // generate iron sword
            Swords.Add(createItem(Global.ItemType.weapon, "železný meč", 10));
            // generate Steel sword
            Swords.Add(createItem(Global.ItemType.weapon, "ovelový meč", 17));


        }
        private void generateEnemyNames()
        {
            enemyNames.Add("Duch");
            enemyNames.Add("Vlk");
            enemyNames.Add("Medvěd");
            enemyNames.Add("Dryáda");
            enemyNames.Add("Bláto");
        }

        private Item createItem(Global.ItemType itemType, string itemName, int itemValue)
        {
            return new Item(itemName, itemValue + ((Global.rng.Next(8, 16) * itemValue)), itemValue, itemType);
        }
    }
}
