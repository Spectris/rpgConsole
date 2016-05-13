using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    
    class Item
    {
        internal string name;
        internal int price, itemValue;                           //Zastupuje jak požkození u zbraně tak obranu u brnění
        internal Global.ItemType itemType;
        /// <summary>
        /// Constructor for Item object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="itemValue"></param>
        /// <param name="itemType"></param>
        public Item(string name, int price, int itemValue, Global.ItemType itemType)
        {
            this.name = name;
            this.price = price;
            this.itemValue = itemValue;
            this.itemType = itemType;
        }
        public string getDetails()
        {
            if(itemType == Global.ItemType.weapon)
                return "" + name + "\t Cena: " + price + "\tPožkození: " + itemValue;
            else
                return "" + name + "\t Cena: " + price + "\tObrana: " + itemValue;
        }
    }
}
