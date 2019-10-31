using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, chet = 0;
            for (int i = 6; i <= 14; i++)
            {
                chet++;
                sum += i;
            }
            Console.WriteLine( sum / chet);
            Console.ReadKey();
        }
    }
}
