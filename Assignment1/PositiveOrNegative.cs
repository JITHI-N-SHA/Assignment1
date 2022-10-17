using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class PositiveOrNegative
    {
        static void Main(string[] args)
        {
            int num = -4;
            if (num < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is positive");
            }
            Console.ReadLine();
        }
    }
}
