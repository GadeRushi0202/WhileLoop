using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Factores
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());

            int i = 2;
            while(i <= num)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.WriteLine();
        }
    }
}




