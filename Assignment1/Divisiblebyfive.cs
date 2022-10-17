using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Divisiblebyfive
    {
        static void Main(string[] args)
        {
            int n = 25;
            if (n % 5 == 0)
            {
                Console.WriteLine("divisible by 5");
            }
            else
            {
                Console.WriteLine("Not divisible by 5");
            }
            Console.ReadLine();


        }
    }
}
