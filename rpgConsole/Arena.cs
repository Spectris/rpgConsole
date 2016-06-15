﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rpgConsole
{
    class Arena
    {
        private static Enemy boss1 = new Enemy("BOSS-EIN", 200, 15);
        public static void EnterArena(Player player)
        {
            Console.WriteLine(texts.ArenaEntery + "\n\nChceš se utkat s prvním šampionem arény {0} (ano/ne)", boss1.name);
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
                Console.WriteLine("Zaútočil jsi za :" + player.GetDmg());
                enemyHp -= player.GetDmg();
                if ((enemy.dmg - player.GetDef()) < 0)
                    dealtDmg = 0;
                else
                    dealtDmg = enemy.dmg - player.GetDef();
                Console.WriteLine(enemy.name + " na tebe zaútočil a způsobil ti zranění ve víši " + dealtDmg + " životů");
                playersHp -= dealtDmg;

                Console.WriteLine("____________________________________________________\nReport of round:\t{0}\n\tPlayer hp:\t{1}\n\tEnemy hp:\t{2}\n", round, playersHp, enemyHp);
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
