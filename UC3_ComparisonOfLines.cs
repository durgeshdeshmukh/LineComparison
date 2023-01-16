using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class UC3_ComparisonOfLines
    {
        public static void ComparisonOfLines()
        {
            //Length of 1st line
            double x1, x2, y1, y2, l1;
            Console.WriteLine("Enter value of x1");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of x2");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of y1");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of y2");
            y2 = double.Parse(Console.ReadLine());

            l1 = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));

            //Console.WriteLine(L1);

            //Length of 2nd line
            double x3, x4, y3, y4, l2;
            Console.WriteLine("Enter value of x3");
            x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of x4");
            x4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of y3");
            y3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of y4");
            y4 = double.Parse(Console.ReadLine());

            l2 = Math.Sqrt((Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2)));

            //Console.WriteLine(L2);

            if (l1 > l2)
            {
                Console.WriteLine("line L1 is greater than L2");
            }
            else if( l1 < l2 )
            {
                Console.WriteLine("line L1 is smaller than L2");
            }
            else
            {
                Console.WriteLine("line L1 is equal to L2");
            }


        }
    }
}
