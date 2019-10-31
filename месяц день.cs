using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace месяц_день
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день");
            double number_d = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц");
            double number_m = double.Parse(Console.ReadLine());
            switch (number_m)
            {
                case 1:
                    Console.WriteLine(number_d - 1);
                    Console.WriteLine(number_m + 11);
                    break;
                case 3:
                    Console.WriteLine(number_d - 1);
                    Console.WriteLine(number_m - 1);
                    break;
                case 5:
                    Console.WriteLine(number_d - 1);
                    Console.WriteLine(number_m - 1);
                    break;
                case 7:
                    Console.WriteLine(number_d - 1);
                    Console.WriteLine(number_m - 1);
                    break;
                case 8:
                    Console.WriteLine(number_d - 1);
                    Console.WriteLine(number_m - 1);
                    break;
                case 10:
                    Console.WriteLine(number_d - 1);
                    Console.WriteLine(number_m - 1);
                    break;
                case 12:
                    Console.WriteLine(number_d - 1);
                    Console.WriteLine(number_m - 1);
                    break;
                case 4:
                    Console.WriteLine(number_d - 1);
                    Console.WriteLine(number_m - 1);
                    break;
                case 6:
                    Console.WriteLine(number_d - 1);
                    Console.WriteLine(number_m - 1);
                    break;
                case 9:
                    Console.WriteLine(number_d - 1);
                    Console.WriteLine(number_m - 1);
                    break;
                case 11:
                    Console.WriteLine(number_d - 1);
                    Console.WriteLine(number_m - 1);
                    break;
                case 2:
                    Console.WriteLine(number_d - 1);
                    Console.WriteLine(number_m - 1);
                    break;
                default:
                    Console.WriteLine("ОШИБКА");
                    break;
            }
            Console.ReadKey();
        }
    }
}