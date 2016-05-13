using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    class City
    {
        private static ObjectList o;
        private static bool firstTime = true;
        internal static void Entry()
        {
            
                o = new ObjectList();
                if (firstTime)
                {
                    Console.WriteLine(texts.CityFirstTime);
                }
                bool run = true;
                while (true)
                {
                    switch (inputParser.ReadLine())
                    {
                        case "prehled":
                            Global.player.GetInfo();
                            break;
                        case "zbrojir":
                            Weapons();
                            break;
                        case "z5": run = false; break;
                        default: break;
                    }
                }
            
           
        }

        private static void Weapons()
        {
            Console.WriteLine("wilkomen in zbrojir");
            bool run = true;
            while (run)
            {
                switch (inputParser.ReadLine())
                {
                    case "seznam":
                        o.printDecs(Global.ItemType.weapon);
                        break;

                    case "z5": run = false; break;
                }
            }
        }
        private static void buy(Item item, int price)
        {
            if(Global.player.money >= price)
            {
                Global.player.weapon = item;
                Global.player.money -= price;
            }
        }

    }
}
