using System;

namespace Task_I
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            bool asd = double.TryParse(Console.ReadLine(), out a);
            if (asd)
            {
                Console.Write(Math.Round(a+1)-1);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}