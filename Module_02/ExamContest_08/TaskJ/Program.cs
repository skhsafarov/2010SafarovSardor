using System;
using System.Linq;

class Program
{
    public static void Main()
    {
        var a = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
        var b = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
        var c = new int[a.Length + 1, b.Length + 1];
        for (int i = 1; i < a.Length + 1; i++)
        {
            for (int j = 1; j < b.Length + 1; j++)
            {
                c[i, j] = (a[i - 1] == b[j - 1]) ? c[i - 1, j - 1] + 1 : Math.Max(c[i - 1, j], c[i, j - 1]);
            }
        }
        Console.WriteLine(c[a.Length, b.Length]);
        return;
    }
}