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
            Console.WriteLine("Boj hráče" + player.name + " prooooooooooooooooooooooti " + enemy.name + "ovi");
            if (fightLoop(player, enemy))
            {
                Console.WriteLine("Vyhrál jsi :)");
                player.AddExp(enemy.hp + enemy.dmg);
            }
            else
                Console.WriteLine("njn, nikdo nemůže vyhrávat pořád a ty nejsi vyjímkou ;)");
        }
        private static bool fightLoop(Player ply, Enemy enem)
        {
            int plyPower = ply.GetDmg() + ply.hp;
            int enemPower = enem.dmg + enem.hp - ply.GetDef();
            if(plyPower > enemPower)
            {
                return true;
            }
            else if (plyPower == enemPower)
            {
                Console.WriteLine("To bylo jen tak tak ..");
                return true; 
            }
            else
            {
                return false;
            }
        }

    }
}
