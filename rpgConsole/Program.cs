using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    class Program
    {
        private static Random rng = new Random();
        
        static void Main(string[] args)
        {
            bool run = true;
            while (run)                                         
            {

#if DEBUG
                Console.WriteLine("RPG CONSOLE [DEBUG]");
#else
                Console.WriteLine("RPG CONSOLE");
#endif

                Console.WriteLine(texts.helpQuoteMenu.Replace("\\n", "\n"));
                switch (Console.ReadLine().ToLower())
                {
                    // '.Replace("\\n", "\n")' after resources string make it possible to use escape sequences
                    case "help":
                        Console.WriteLine(texts.helpQuoteMenu.Replace("\\n", "\n"));
                        break;
                    case "zacit":
                        Hra();                                                                                                   
                        break;
                    
                    case "konec":
                        run = false;
                        break;
                    default: break;
                }
            }

            Console.Clear();    Console.WriteLine("Dostal jsi se na konec světa\nStiskni jakékoliv tlačítko pro ukončení");    Console.ReadKey();  
        }
        private static Player CharacterCreation()
        {
            Console.Write("Nyní pojmenuj svého hrdinu: "); string name = Console.ReadLine();
            return new Player(name, rng.Next(15, 21), rng.Next(0,3), rng.Next(1, 3), 1);
        }

        private static void Hra()
        {
            Global.player = CharacterCreation();
            Console.WriteLine(texts.helpQuoteGame.Replace("\\n", "\n"));
            bool run = true;
            while (run)                                        
            {
                switch (Console.ReadLine().ToLower())
                {
                    case "help":
                        Console.WriteLine(texts.helpQuoteGame.Replace("\\n", "\n"));
                        break;
                    case "arena":
                        Arena.EnterArena(Global.player);
                        break;

                    case "les":
                        Forest.Entry();
                        break;

                    case "obchodnik":
                        ShopeKeeper.Entry();
                        break;

                    case "dul":
                        Mine.Entry();
                        break;

                    case "prehled":
                        Console.WriteLine(Global.player.GetInfo());
                        break;
                    case "clear": Console.Clear(); break;

                    case "konec":
                        run = false;
                        break;

                    default: break;

                }
            }
        }
    }
}
