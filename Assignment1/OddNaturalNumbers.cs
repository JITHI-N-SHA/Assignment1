using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class OddNaturalNumbers
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.WriteLine("Enter the value of n");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The odd numbers are");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                    Console.WriteLine(i);
                }

            }
            Console.WriteLine("The sum odd numbers are=" + sum);

            Console.ReadLine();
        }
    }
}
