using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    //Generate Fibonacci series. 0,1, 1, 2, 3, 5,8 ….. k. where k < n . n is entered by user
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int series = Convert.ToInt32(Console.ReadLine());
            int f1 = 0;
            int f2 = 1;
            int i = 2;

            while(i< series)
            {
                int f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
                
                i++;
            }

        }
    }
}
