using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    class Cmd
    {
        private static readonly string password = "123";            
        public static void Verify()
        {
           
            Console.Write("Příkazová konzole\n\tZadej heslo pro přístup: ");

            if (Console.ReadLine() == password)        //change this password to protect cmd from players (recomand to use hashed password as protection from decompilation)
            {
                cmd(Global.player);
            }
           

        }

        private static void cmd(Player player)
        {
            Console.WriteLine("Vývojářská konzole..\n");
            bool run = true;
            while (run)
            {
                switch (Console.ReadLine().ToLower())
                {
                    case "lvlup": player.AddExp((player.lvl * player.lvl) + (6 * player.lvl) - player.exp); Console.WriteLine("lvl added\n\t\t actual lvl: " + player.lvl); break;
                    case "godmode": player.GodMode(); Console.WriteLine("God mode items added");
                        break;

                    case "z5":
                        run = false;
                        break;
                    default: break;
                }
            }
        }
    }
}
