using System;

namespace Task_J
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, a;
            bool asd1 = double.TryParse(Console.ReadLine(), out x);
            bool asd2 = double.TryParse(Console.ReadLine(), out y);
            if(asd1 && asd2)
            {
                a = x * x + y * y;
                if (a <= 2 && a >= 1)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
