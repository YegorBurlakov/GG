using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0, fac1 = 1, fac3 = 1;
            double m = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            double i, j;
            if (n < m)
            {
                for (i = 1; i <= m; i++)
                {
                    fac1 *= i;
                    for (j = 1; j <= n; j++)
                        fac3 *= (m - n);
                    Console.WriteLine(result = j / (fac1 * fac3));
                }
            }
            else if (m < n)
            {
                for (i = 1; i <= n; i++)
                {
                    fac1 *= i;
                    for (j = 1; j <= m; j++)
                        fac3 *= (m - n);
                    Console.WriteLine(result = j / ((fac1) * fac3));
                }
            }
            Console.ReadKey();
        }
    }
}