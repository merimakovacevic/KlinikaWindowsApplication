﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class IDManager
    {
        static int broj;
        public static int dajNoviID()
        {
            return broj++;
        }
    }
}
