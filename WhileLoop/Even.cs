using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Even
    {
        //Print even number from 1 to 100 (if)
        static void Main(string[] args)
        {
            int i = 1;
            while(i <= 100)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
