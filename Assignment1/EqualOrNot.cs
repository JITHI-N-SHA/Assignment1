using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class EqualOrNot
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("The given two numbers are equal");
            }
            else
            {
                Console.WriteLine("The given two numbers are not equal");
            }
            Console.ReadLine();
        }
    }
}
