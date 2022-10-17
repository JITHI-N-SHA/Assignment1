using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class SumOfNaturalNumbers
    {
        static void Main(string[] args)
        {
            int i, s = 0;
            for (i = 1; i <= 10; i++)
            {
                s = s + i;

            }
            Console.WriteLine("sum of 10 natural numbers are" + s);
            Console.ReadLine();
        }
    }
}
