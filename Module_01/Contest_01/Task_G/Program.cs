using System;

namespace Task_G
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            int b;
            bool asd1 = double.TryParse(Console.ReadLine(), out a);


            if (asd1 && a >= 0)
            {
                b = (int)(a * 10) - (int)a * 10;
                Console.Write(b);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}