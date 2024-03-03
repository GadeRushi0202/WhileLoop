using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Armstrong
    {
        static void Main(string[] args)
        {
            // check that number is armstrong number or not
            // 153  ->  (1*1*1)+ (5*5*5*)+(3*3*3) 
            //            1 +    125 +  27 --> 153

            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());// num=153
            int temp = num;
            int sum = 0;
            while (num != 0)// 153!=0   15!=0  1!=0  0!=0
            {
                int rem = num % 10; // % 10 --> rem=3   rem=5 1
                sum = sum + (rem * rem * rem); // sum=153   0+ 27   125+27
                num = num / 10;//   153/10  --> 15/10  1/10 0
            }

            if (temp == sum)
            {
                Console.WriteLine("It is an Amstrong number");
            }
            else
            {
                Console.WriteLine("It is not an Amstrong number");
            }

        }

    }
}
