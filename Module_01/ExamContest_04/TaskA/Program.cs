using System;

class Program
{
    public static void Main(string[] args)
    {
        bool asd = short.TryParse(Console.ReadLine(), out short a);
        bool asd1 = short.TryParse(Console.ReadLine(), out short b);
        if (asd && asd1)
        {
            Console.WriteLine(a ^ b);
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }
    }
}