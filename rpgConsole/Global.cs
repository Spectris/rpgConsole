﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgConsole
{
    public static class Global
    {
        public enum ItemType
        {
            weapon,
            armour,
            none
        }

        //player instance
        internal static Random rng = new Random();
        internal static Player player;
        internal static ObjectList objectList = new ObjectList();



    }
}
