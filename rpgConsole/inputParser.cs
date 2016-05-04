using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    class inputParser
    {
        
        /// <summary>
        /// warn: when using during fight skip one round, but enemy will hit you
        /// </summary>
        /// <returns></returns>
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
