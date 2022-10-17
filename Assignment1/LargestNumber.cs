using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class LargestNumber
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of c");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("a is the largest number");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("b is the largest number");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("c is the largest number");
            }
            else
            {
                Console.WriteLine("no output");
            }
            Console.ReadLine();
        }
    }
}
