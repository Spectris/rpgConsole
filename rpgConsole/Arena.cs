using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rpgConsole
{
    class Arena
    {
        private static Enemy boss1 = new Enemy("Herald veliký","Heraldem Velikým", 200, 15);
        public static void EnterArena(Player player)
        {
            Console.WriteLine(texts.ArenaEntery + "\n\nChceš se utkat s prvním šampionem arény {0} (ano/ne)", boss1.plural);
            if (Console.ReadLine().ToLower() == "ano")
            {
                if (fightLoop(Global.player, boss1))
                {
                    Console.WriteLine("Vyhrál jsi");
                    Global.player.AddExp(boss1.hp + boss1.dmg);
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
                Console.WriteLine("Udělil jsi požkození ve výši :" + player.GetDmg());
                enemyHp -= player.GetDmg();
                if ((enemy.dmg - player.GetDef()) < 0)
                    dealtDmg = 0;
                else
                    dealtDmg = enemy.dmg - player.GetDef();
                Console.WriteLine(enemy.name + " na tebe zaútočil a způsobil ti zranění ve víši " + dealtDmg + " životů");
                playersHp -= dealtDmg;

                Console.WriteLine("\n____________________________________________________\nZpráva za kolo:\t{0}\n\tZdraví hráče:\t\t{1}\n\tZdraví Protivníka:\t{2}\n", round, playersHp, enemyHp);
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
