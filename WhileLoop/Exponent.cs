using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Exponent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Number");
            int power = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            int i = 1;

            while( i <= power)
            {
                result = result * b;
            }
            Console.WriteLine(result);
            i++;
        }
    }
}




