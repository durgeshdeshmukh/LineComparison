using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class UC1_LengthOfLine
    {
        public static void LengthOfLine()
        {
            double x1, x2, y1, y2, LengthOfLine;
            Console.WriteLine("Enter value of x1");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of x2");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of y1");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of y2");
            y2 = double.Parse(Console.ReadLine());

            double a, b, m, n, A, r;
            a = x2 - x1;
            b = y2 - y1;

           const int p = 2;

            m = Math.Pow(a, p);
            n = Math.Pow(b, p);

            //Console.WriteLine(m);
            //Console.WriteLine(n);

            A = (m + n);

            //Console.WriteLine(A);

            r = Math.Sqrt(A);

            Console.WriteLine("length of line " + r);

            //Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));

            Console.WriteLine("length of line " + Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2))) );

        }
    }
}
