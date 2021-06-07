using System;

partial class Program
{
    public static void Main(string[] args)
    {
        bool asd = double.TryParse(Console.ReadLine(), out double n);
        bool asd1 = int.TryParse(Console.ReadLine(), out int k);
        if (asd && asd1 && k >= 0)
        {
            if (k == 0)
            {
                n = 1;
            }
            else
            {
                double n1 = n;
                for (int i = 1; i < k; i++)
                {
                    n = n * n1;
                }
            }
            Console.WriteLine(n);
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }
    }
}