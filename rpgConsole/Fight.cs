using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    static class Fight
    {

        internal static void start(Player player, Enemy enemy)
        {
            Console.WriteLine("Hráč             Nepřítel\njméno: " + player.name + "             jméno: " + enemy.name + "\nBoj nastává");
            if (fightLoop(player, enemy))
            {
                Console.WriteLine("Vyhrál jsi :)");
            }
            else
                Console.WriteLine("njn, nikdo nemůže vyhrávat pořád a ty nejsi vyjímkou ;)");
        }
        private static bool fightLoop(Player ply, Enemy enem)
        {
            int tempPlayer = ply.hp * ply.dmg;
            int tempEnemy = enem.hp * enem.dmg;

            if (tempPlayer > tempEnemy)
                return true;
            else
                return false;
        }

    }
}
