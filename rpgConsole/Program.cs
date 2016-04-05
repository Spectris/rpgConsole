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
                switch (Console.ReadLine().ToLower())
                {
                    case "help":
                        Console.WriteLine("Nápověda k ovládaní\n   help - zobrazí nápovědu\n   O - zobrazí informace o hře\n   zacit - započíst hru");
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
            return new Player(name, 20, 1);
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
                        Console.WriteLine("Nápověda k ovládaní\n    help - zobrazí nápovědu\n    pruzkum - průzkum okolí (prohledáš široké okolí)\n    prohledat - prohledá bezprostřední oklí hráče\n    boj - započne boj s nalezeným nepřítelem");
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
                        Player ply = new Player("hrac", 10, 1);
                        Enemy enemy = new Enemy("duch", 5, 1);
                        Fight.start(ply, enemy);
                        // Konecc testu boje
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
