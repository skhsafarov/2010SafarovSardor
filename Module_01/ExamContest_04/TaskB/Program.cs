using System;

partial class Program
{
    public static void Main(string[] args)
    {
        bool asd = uint.TryParse(Console.ReadLine(), out uint a);
        bool asd1 = uint.TryParse(Console.ReadLine(), out uint b);
        bool asd2 = uint.TryParse(Console.ReadLine(), out uint c);
        if (asd && asd1 && asd2 && ((a + b) > c && (b + c) > a && (c + a) > b))
        {
            Console.WriteLine(a + b + c);
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }
    }
}