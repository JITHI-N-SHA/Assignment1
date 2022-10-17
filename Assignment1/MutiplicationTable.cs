using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class MutiplicationTable
    {
        static void Main(string[] args)
        {
            int num, mul;
            Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            for (mul = 0; mul <= 10; mul++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, mul, (num * mul));
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
