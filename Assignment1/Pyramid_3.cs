using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Pyramid_3
    {
        static void Main(string[] args)
        {
            int n = 5;
           
            for(int i=1;i<=n;++i)
            {
                for(int j=1;j<=i;++j)
                {
                    Console.Write(j + " ");
                   
                }
                Console.WriteLine("\n");
            }         
            Console.ReadLine();
        }
    }
}
