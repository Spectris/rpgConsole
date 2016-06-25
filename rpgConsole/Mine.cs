using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    class Mine
    {
        static int oreValue, max;
        static bool first = true;
        internal static void Entry()
        {
            if (first)
            {
                Console.WriteLine(texts.firstQuotaMine.Replace("\\n", "\n"));
                first = false;
            }
            else
                Console.WriteLine("Výtej v dole na růhy, tady si můžeš vydělat nějakou tu kačku když zrovna nebudeš mít nic na práci");
            bool run = true;
            while(run)
            {
                switch(Console.ReadLine().ToLower())
                {
                    case "help":
                        Console.WriteLine(texts.helpQuotaMine.Replace("\\n","\n"));
                        break;
                    case "p":
                        Global.player.money = DoMine(1);
                        break;
                    case "s":
                        Global.player.money = DoMine(10);
                        break;
                    case "h":
                        Global.player.money = DoMine(100);
                        break;
                    case "z5":
                        run = false;
                        break;

                    default: break;
                }
            }
        }


        private static int DoMine(int luck)
        {
            oreValue = Global.rng.Next(2 + luck, 6 + luck);
            max = 1000 / luck;
            luck = Global.rng.Next(0 , max);
#if DEBUG
            Console.WriteLine("DEBUG : \n Luck : {0}\n Ore value: {1}", luck, oreValue);
            Console.ReadLine();
#endif
            if (!(luck == Global.rng.Next(0, max)))
            {
                Console.WriteLine("Celý den jsi těžil v dole a vytěžil jsi růhy v ceně {0} zlatých a nic se ti během toho nestalo", oreValue);
            }
            else
            {
                Console.WriteLine("Celý den jsi těžil v dole a vytěžil jsi růhy v ceně {0} zlatých a během výstupu z dolu jsi se zranil (-1 k celkevému zdraví)", oreValue);
                Global.player.hp--;
            }
            return oreValue;
        }

       
    }
}
