using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    class inputParser
    {
        internal static string ReadLine()
        {
            string input = Console.ReadLine().ToLower();
            switch(input)
            {
                case "cmd":
                    Cmd.Verify();
                    return "";
                    
                default: return input;
            }
            
        }
    }
}
