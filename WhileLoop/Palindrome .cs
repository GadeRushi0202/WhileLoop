using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());

            int rev = 0;
            int temp = num;
            while (num != 0)
            {
                int rem = num % 10;
                rev = (rev * 10) + rem;
                num = num / 10;

            }
            num = temp;
            if(num == rev)
            {
                Console.WriteLine("Palindrome Number");
            }
            else
            {
                Console.WriteLine("Not Palindrome Number");
            }
            Console.WriteLine(rev);

        }
    }
}
