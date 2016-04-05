using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    enum ItemType
    {
        weapon,
        armour,
        food
    }
    class Item
    {
        internal string name;
        internal int price, itemValue;                           //Zastupuje jak požkození u zbraně tak obranu u brnění
        internal ItemType itemType;
        /// <summary>
        /// Constructor for Item object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="itemDmg"></param>
        /// <param name="itemType"></param>
        public Item(string name, int price, int itemDmg, ItemType itemType)
        {
            this.name = name;
            this.price = price;
            this.itemValue = itemDmg;
            this.itemType = itemType;
        }
    }
}
