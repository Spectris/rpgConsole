using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    class Mine
    {
        bool first = true;
        internal void Entry()
        {
            Console.WriteLine("Výtej v dole na růhy, tady si můžeš vydělat nějakou tu kačku když zrovna nebudeš mít nic na práci");
            if (first)
            {
                Console.WriteLine(texts.firstQuotaMine.Replace("\\n", "\n"));
                first = false;
            }
            bool run = true;
            while(run)
            {
                switch(Console.ReadLine().ToLower())
                {
                    case "help":
                        Console.WriteLine(texts.helpQuotaMine.Replace("\\n","\n"));
                        break;
                    case "p":

                        break;
                    case "":

                        break;
                    case "":

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
