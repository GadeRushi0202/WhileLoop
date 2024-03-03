using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    //Print 1- 10 & its sum
    internal class Sum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            while(i <= 10)
            {
                sum = sum + i;
                Console.WriteLine(sum);
                i++;
            }
        }
    }
}
