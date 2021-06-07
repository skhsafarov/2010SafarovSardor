using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int>();
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int a) && a >= 100 && a <= 150)
            {
                list.Add(a);
            }
            else if (a == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Incorrect number");
            }
        }
        list.Sort();
        Console.WriteLine(list[list.Count - 1]);
        Console.WriteLine(list[list.Count - 2]);
    }
}