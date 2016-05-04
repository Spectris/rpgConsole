using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static rpgConsole.Global;

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
                Console.WriteLine(texts.gameMenuEntry + "\n");
                Console.WriteLine(texts.helpQuoteMenu.Replace("\\n", "\n"));
                switch (Console.ReadLine().ToLower())
                {
                    // '.Replace("\\n", "\n")' after resources string make it possible to use escape sequences
                    case "help":
                        Console.WriteLine(texts.helpQuoteMenu.Replace("\\n", "\n"));
                        break;
                    case "o":
                        Console.WriteLine("vypisuji //TODO: zobrazení informací o hře");
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
            player = CharacterCreation();
            Console.WriteLine(texts.helpQuoteGame.Replace("\\n", "\n"));
            bool run = true;
            while (run)                                        
            {
                switch (inputParser.ReadLine())
                {
                    case "help":
                        Console.WriteLine(texts.helpQuoteGame.Replace("\\n", "\n"));
                        break;

                    case "pruzkum":
                        Console.WriteLine("Prozkoumávám //TODO: implementace průzkumu okolí");
                        break;

                    case "arena":
                        Arena.EnterArena( player );
                        break;

                    case "boj":
                        //  test of battle
                        Enemy enemy = new Enemy("duch", 5, 1);
                        Fight.start(player, enemy);
                        // tests end
                        break;

                    case "prehled":
                        Console.WriteLine(player.GetInfo());
                        break;

                    case "mesto":
                        break;
                    case "clear": Console.Clear(); break;

                    case "z5":
                        run = false;
                        break;

                    default: break;

                }
            }
        }
    }
}
