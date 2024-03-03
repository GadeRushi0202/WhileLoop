using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Fact
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int Fact = 1;
            int i = 1;

            while (i <= num)
            {
                
                Fact = Fact * i;
                Console.WriteLine(Fact);
                i++;
            }
        }
    }
}
