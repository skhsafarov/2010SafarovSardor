using System;

partial class Program
{
    static void Main(string[] args)
    {
        bool asd1 = int.TryParse(Console.ReadLine(), out int a);
        bool asd2 = int.TryParse(Console.ReadLine(), out int b);
        int c = a - b;
        if (asd1 && asd2 && c < 0)
        {
            for (int i = a; i < b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }
    }
}