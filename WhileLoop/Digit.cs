using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    //Find the sum of all digits of a number.  → 123 ⇒ 1+2+3 → 6

    internal class Digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int sum = 0;

            while (num != 0)
            {
                int rem = num % 10;
                sum = sum + rem;
                num = num / 10;
                

            }
            Console.WriteLine(sum);
        }
    }
}
