using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rpgConsole
{
    static class Forest
    {

        internal static void Entry()
        {
            Console.WriteLine(texts.helpQuoteForest.Replace("\\n", "\n"));
            bool run = true;
            while (run)
            {
                switch (Console.ReadLine())
                {
                    case "lov":
                        HuntStart();
                        break;

                    case "help":
                        Console.WriteLine(texts.helpQuoteForest.Replace("\\n","\n"));
                        break;

                    case "z5":
                        run = false;
                        break;

                    default: break;
                }
            }
        }

        private static void HuntStart()
        {
            Enemy enemy = new Enemy(Global.objectList.enemyNames[Global.rng.Next(0, 6)], Global.rng.Next(1, 8), Global.rng.Next(1, 4));
            Console.WriteLine("Během své výpravi jsi narazil na " + enemy.name + "\nChceš zaútočit? (ano/ne)");

            if (Console.ReadLine().ToLower() == "ano")
            {
                if (fightLoop(Global.player, enemy))
                {
                    Console.WriteLine("Vyhrál jsi");
                    Global.player.AddExp(enemy.hp + enemy.dmg);
                }
                else
                    Console.WriteLine("Prohrál jsi");
            }
        }

        private static bool fightLoop(Player player, Enemy enemy)
        {
            //temp variables
            int playersHp = player.hp;
            int enemyHp = enemy.hp;
            int round = 0;
            int dealtDmg = 0;
            //

            bool run = true;
            while (run)
            {
                round++;
                Console.WriteLine("Udělil jsi požkození ve výši : " + player.GetDmg() + "životů");
                enemyHp -= player.GetDmg();
                if ((enemy.dmg - player.GetDef()) < 0)
                    dealtDmg = 0;
                Console.WriteLine(enemy.name + " na tebe zaútočil a způsobil ti zranění ve víši " + dealtDmg + " životů");
                playersHp -= dealtDmg;

                Console.WriteLine("\n____________________________________________________\nZpráva za kolo:\t{0}\n\tZdraví hráče:\t{1}\n\tZdraví kořisti:\t{2}\n", round, playersHp, enemyHp);
                Thread.Sleep(600);
                if (enemyHp <= 0)
                    return true;
                if (playersHp <= 0)
                    return false;
            }
            Console.WriteLine("Fight-afterfight : out of standart method range.");
            return false;
        }

    }
}
