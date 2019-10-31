using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_a = int.Parse(Console.ReadLine());
            int number_c = int.Parse(Console.ReadLine());
            int number_d = int.Parse(Console.ReadLine());
            Console.WriteLine("Решение задачи номер  = {0}",
                (Math.Atan (number_c / 4) - number_d * 62) / (number_a * number_a - 1));
            Console.ReadKey();
        }
    }
}
