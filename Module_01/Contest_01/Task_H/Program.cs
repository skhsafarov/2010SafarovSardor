using System;

namespace Task_H
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            bool asd = char.TryParse(Console.ReadLine(), out a);
            if (asd && a >= 'a' && a <= 'z')
            {
                Console.WriteLine((int)a - 96);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }

        }
    }
}
