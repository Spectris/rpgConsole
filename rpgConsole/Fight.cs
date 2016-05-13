using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    static class Fight
    {

        internal static void start(Enemy enemy)
        {
            Console.WriteLine("Boj hráče" + Global.player.name + " proti " + enemy.name + "ovi");
            if (fightLoop(Global.player, enemy))
            {
                Console.WriteLine("Vyhrál jsi");
                Global.player.AddExp(enemy.hp + enemy.dmg);
            }
            else
                Console.WriteLine("Prohrál jsi");
        }
        private static bool fightLoop(Player player, Enemy enemy)
        {
            //temp variables
            int playersHp = player.hp;
            int enemyHp = enemy.hp;
            int rount = 0;
            //

            bool run = true;
            while(run)
            {
                rount++;
                Console.WriteLine("na tahu je hráč\nZ - zaútočit\tS - stáhnout se");
                switch(inputParser.ReadLine())
                {
                    case "z":
                        enemyHp -= player.GetDmg();
                        break;

                    case "s":
                        return false;

                    default: break;
                }
                if (enemyHp <= 0)
                    return true;
                if (playersHp <= 0)
                    return false;
                playersHp -= enemy.dmg;
                Console.Clear();Console.WriteLine("Round report\n\tPlayer hp:\t{0}\n\tEnemy hp:\t{1}\n", playersHp, enemyHp);
            }
            /*
            int plyPower = ply.GetDmg() + ply.hp;
            int enemPower = enem.dmg + enem.hp - ply.GetDef();
            if (plyPower > enemPower)
            {
                return true;
            }
            else if (plyPower == enemPower)
            {
                Console.WriteLine("To bylo jen tak tak ...");
                return true;
            }
            else
            {
                return false;
            }*/
            return false;
        }

    }
}
