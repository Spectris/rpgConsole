using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Console.WriteLine("Toto je úvod");
            while (run)                                         //Havní smyčka programu
            {
                Console.WriteLine(texts.gameMenuEntry);
                switch (Console.ReadLine().ToLower())
                {
                    // '.Replace("\\n", "\n")' after resources string make it possible to use escape sequence
                    case "help":
                        Console.WriteLine(texts.helpQuoteMenu.Replace("\\n", "\n"));
                        break;
                    case "o":
                        Console.WriteLine("vypisuji //TODO: zobrazení informací o hře");
                        break;
                    case "zacit":
                        Console.WriteLine("zahajuji  //TODO: Zahájení hry a vytvoření characteru");
                        Hra();                                                                                                  // tady začíná hra  
                        break;
                    
                    case "konec":
                        run = false;
                        break;
                    default: break;
                }
            }
            Console.Clear();    Console.WriteLine("Toto je konec hry\nStiskni jakékoliv tlačítko pro ukončení");    Console.ReadKey();  
        }
        private static Player CharacterCreation()
        {
            Console.Write("Zadej jméno tvojí postavy: "); string name = Console.ReadLine();
            return new Player(name, 20, 0, 1, 1);
        }

        private static void Hra()
        {
            Player player = CharacterCreation();
            bool run = true;
            while (run)                                         //Havní smyčka hry
            {
                switch (Console.ReadLine().ToLower())
                {
                    case "help":
                        Console.WriteLine(texts.helpQuoteGame.Replace("\\n", "\n"));
                        break;

                    case "pruzkum":
                        Console.WriteLine("Prozkoumávám //TODO: implementace průzkumu okolí");
                        break;

                    case "arena":
                        Console.WriteLine("vstupuji do areny  //TODO: implementace areny. klíčová součást hry");
                        break;

                    case "boj":
                        Console.WriteLine("Začínám boj  //TODO: implementace bojového rozhraní, zahájení boje");
                        //  Test boje
                        Enemy enemy = new Enemy("duch", 5, 1);
                        Fight.start(player, enemy);
                        // Konecc testu boje
                        break;

                    case "prehled":
                        Console.WriteLine(player.getInfo());
                        break;
                    case "clear": Console.Clear(); break;

                    case "menu":
                        run = false;
                        break;

                    default: break;

                }
            }
        }
    }
}
