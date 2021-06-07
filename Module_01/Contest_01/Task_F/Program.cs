using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_F
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            bool asd1 = double.TryParse(Console.ReadLine(), out a);
            bool asd2 = double.TryParse(Console.ReadLine(), out b);
            c = Math.Round(Math.Sqrt(a * a + b * b), 5);
            if (asd1 && asd2 && a > 0 && b > 0)
            {
                Console.Write(c);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
