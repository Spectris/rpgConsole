using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    class ShopeKeeper
    {
        internal static void Entry()
        {
            Console.WriteLine("Výtej v mém obchodě dobrodruhu... Mohu ti nabídnout jak (Z)braně, tak i (B)rnění a nebo se můžeš vrátit (Z)pět do města");
            bool run = true;
            while (run)
            {
                switch (Console.ReadLine().ToLower())
                {

                    case "z":
                        Weapons();
                        break;
                    case "b":
                        Armours();
                        break;
                    case "help":
                        Console.WriteLine(texts.helpQuoteShop.Replace("\\n","\n"));
                        break;
                    case "z5":
                        run = false;
                        break;
                    default: break;
                }
            }
        }

        private static void Weapons()
        {
            Console.WriteLine("Zbraně tady mám z\n\tMědi - 1\n\tBronz - 2\n\tŽeleza - 3\n\tOcel - 4\n\tz5 - návrat do výběru sortimentu");
            bool run = true;
            while (run)
            {
                switch (Console.ReadLine().ToLower())
                {

                    case "1":
                        buyWeapon(0);
                        break;
                    case "2":
                        buyWeapon(1);
                        break;
                    case "3":
                        buyWeapon(2);
                        break;
                    case "4":
                        buyWeapon(3);
                        break;
                    case "z5": run = false; break;
                    default: Console.WriteLine("Mám tady pouze tyto čtyři možnosti"); break;
                }
            }
        }

        private static void Armours()
        {
            Console.WriteLine("Brnění tady mám z\n\tMědi - 1\n\tBronz - 2\n\tŽeleza - 3\n\tOcel - 4\n\tz5 - návrat do výběru sortimentu");
            bool run = true;
            while (run)
            {
                switch (Console.ReadLine().ToLower())
                {

                    case "1":
                        buyArmour(0);
                        break;
                    case "2":
                        buyArmour(1);
                        break;
                    case "3":
                        buyArmour(2);
                        break;
                    case "4":
                        buyArmour(3);
                        break;
                    case "z5": run = false; break;
                    default: Console.WriteLine("Mám tady pouze tyto čtyři možnosti"); break;
                }
            }
        }

        private static void buyWeapon(int WIndex)
        {
            Console.WriteLine("Zbraň tě bude stát " + Global.objectList.Swords[WIndex].price + "g opravdu si ji chceš koupit? (ano/ne)");
            if (Console.ReadLine().ToLower() == "ano")
            {

                if (Global.player.money > Global.objectList.Swords[WIndex].price)
                {
                    Global.player.money -= Global.objectList.Swords[WIndex].price;
                    Console.WriteLine("Výborně! ... užij si svůj noví " + Global.objectList.Swords[WIndex].name);
                    Global.player.weapon = Global.objectList.Swords[WIndex];
                }
                else
                    Console.WriteLine("Tak na tohle nemáš");
            }

        }

        private static void buyArmour(int WIndex)
        {
            Console.WriteLine("Brnění tě bude stát " + Global.objectList.Armours[WIndex].price + "g opravdu si ho chceš koupit? (ano/ne)");
            if (Console.ReadLine().ToLower() == "ano")
            {
                if (Global.player.money > Global.objectList.Armours[WIndex].price)
                {
                    Global.player.money -= Global.objectList.Armours[WIndex].price;
                    Console.WriteLine("Výborně! ... užij si své nové " + Global.objectList.Armours[WIndex].name);
                    Global.player.armour = Global.objectList.Armours[WIndex];
                }
                else
                    Console.WriteLine("Tak na tohle nemáš");
            }
        }
    }
}
