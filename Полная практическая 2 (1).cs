using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическая_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number_x = double.Parse(Console.ReadLine());
            double number_b = double.Parse(Console.ReadLine());
            const double PI = 3.14;
            const double E = 2.71;
            if ((0<=number_x ) && (number_x <=E))
            {
                Console.WriteLine((3 / 2) * (number_x * number_x) - (Math.Pow(number_b + PI, 1 / 3)));
            }
            else if (number_x>=E)
            {
                Console.WriteLine (Math.Pow(number_b + PI, 2) + Math.Pow(E, number_x + 1));
            }
            else if (number_x < 0)
            {
                Console.WriteLine((2 / 3) * Math.Tan(Math.Pow(number_b, 2) + PI) - Math.Log10(Math.Abs(number_x))); 
            }
            else
            {
                Console.WriteLine ("Ошибка");
            }
            Console.ReadKey();
        }
    }
}
