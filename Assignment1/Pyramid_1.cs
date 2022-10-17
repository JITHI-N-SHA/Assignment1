using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Pyramid_1
    {
        static void Main()
        {
            int n, count;
            Console.WriteLine("n:");
            n = Convert.ToInt32(Console.ReadLine());
            count = n - 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    Console.Write(" ");
                }
                count--;
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }          
            Console.ReadLine();

        }
    }
}
