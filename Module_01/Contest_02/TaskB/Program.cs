using System;
using System.Security.Cryptography.X509Certificates;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, sum;
            sum = 0;
            do
            {
                if (int.TryParse(Console.ReadLine(), out a))
                {
                    if ((a % 2) != 0)
                    {
                        sum = sum + a;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }
            }
            while (a != 0);
            Console.WriteLine(sum);
        }
    }
}