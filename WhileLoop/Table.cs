using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Table
    {
        // Print the table to a number

        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number:-");
            int num = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            while (i <= 10)
            {
                int table = num * i;
                Console.WriteLine(table);
                i++;
            }
           

        }
    }
}
