using System;

class Program
{
    static void Main(string[] args)
    {
        bool asd = uint.TryParse(Console.ReadLine(), out uint a);
        uint sum = 0;
        if (asd)
        {
            while (a > 0)
            {
                sum = sum + a % 10;
                a = a / 10;
            }
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }
    }
}