using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class PrimeNumber
    {     //write code find of factores of number
        //Find if the given number is prime or not.
        static void Main(string[] args)
       {
            /*Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isprime = true;
            /int i = 2;
            while(i < num)
            {
                if(num%i == 0)
                {
                    isprime = false;
                }
                i++;
            }
            if(isprime == true)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }*/
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    a = 0;
                    break;
                }
            }
            if (a == 1)
            {
                Console.WriteLine("prime num");
            }
            else
            {
                Console.WriteLine("Not prime num");
            }
        }
            

           
            

        
    }
}
