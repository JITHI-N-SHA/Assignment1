using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Student
    {
        static void Main(string[] args)
        {
            int rollnumber, sub1, sub2, sub3, total;
            string name;
            double percentage;
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();

            Console.WriteLine("Enter the Roll number");
            rollnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mark of sub1");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mark of sub2");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mark of sub3");
            sub3 = Convert.ToInt32(Console.ReadLine());
            total = sub1 + sub2 + sub3;
            Console.WriteLine("Total marks:" + total);
            percentage = total / 3.0;
            Console.WriteLine("Percentage of marks=" + percentage);

            Console.ReadLine();
        }
    }
}
