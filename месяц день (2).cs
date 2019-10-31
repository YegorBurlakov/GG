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
            int number_d = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц");
            int number_m = int.Parse(Console.ReadLine());
            if ((number_m == 3) && (number_d > 28))
            {
                Console.WriteLine("Ошибка");
            }
            else if (number_m == 1 || number_m == 3 || number_m == 5 || number_m == 7 || number_m == 8 || number_m == 10 || number_m == 12 && number_d > 31 || number_d < 0)
            {
                Console.WriteLine("Ошибка");
            }
            else if (number_m == 4 || number_m == 6 || number_m == 9 || number_m == 11 && number_d > 30)
            {я
                Console.WriteLine("Ошибка");
            }
            else
            {
                switch (number_m)
                {
                    case 1:
                        Console.WriteLine(number_d - 1); Console.WriteLine(number_m + 11);
                        break;
                    case 3:
                        Console.WriteLine(number_d - 1); Console.WriteLine(number_m - 1);
                        break;
                    case 5:
                        Console.WriteLine(number_d - 1); Console.WriteLine(number_m - 1);
                        break;
                    case 7:
                        Console.WriteLine(number_d - 1); Console.WriteLine(number_m - 1);
                        break;
                    case 8:
                        Console.WriteLine(number_d - 1); Console.WriteLine(number_m - 1);
                        break;
                    case 10:
                        Console.WriteLine(number_d - 1); Console.WriteLine(number_m - 1);
                        break;
                    case 12:
                        Console.WriteLine(number_d - 1); Console.WriteLine(number_m - 1);
                        break;
                    case 4:
                        Console.WriteLine(number_d - 1); Console.WriteLine(number_m - 1);
                        break;
                    case 6:
                        Console.WriteLine(number_d - 1); Console.WriteLine(number_m - 1);
                        break;
                    case 9:
                        Console.WriteLine(number_d - 1); Console.WriteLine(number_m - 1);
                        break;
                    case 11:
                        Console.WriteLine(number_d - 1); Console.WriteLine(number_m - 1);
                        break;
                    case 2:
                        Console.WriteLine(number_d - 1);
                        Console.WriteLine(number_m - 1);
                        break;
                    default:
                        Console.WriteLine("ОШИБКА");
                        break;

                }
            }
            Console.ReadKey();
        }
    }
}