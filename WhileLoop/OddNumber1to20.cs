﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class OddNumber1to20
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 20) 
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}

