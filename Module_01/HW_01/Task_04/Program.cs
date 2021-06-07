using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("U = ");

            string napr = Console.ReadLine();

            int U = Convert.ToInt32(napr);

            Console.WriteLine("R = ");

            string sopr = Console.ReadLine();

            int R = Convert.ToInt32(sopr);

            Console.WriteLine("I = "+(U / R));

            Console.WriteLine("P = " +(U*U / R));

            Console.ReadKey();
        }
    }
}
