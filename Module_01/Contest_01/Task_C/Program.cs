using System;

namespace Task_C
{
    class Program
    {
        static void Asd(uint a)
        {
            uint t;
            t = a / 10;
            Console.WriteLine(a - (t * 10));
        }

        static void Main(string[] args)
        {
            uint a;
            string s = Console.ReadLine();
            if (uint.TryParse(s, out a))
            {
                Asd(a);
            }
            else Console.WriteLine("Incorrect input");
        }
    }
}