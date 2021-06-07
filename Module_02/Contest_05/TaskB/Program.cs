using System;
using System.Collections.Generic;
using System.Linq;

internal static class Program
{

    private static void Main(string[] args)
    {
        var a = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();
        var b = new int[a.Length][];
        b[0] = a;
        for (var i = 1; i < b.Length; i++)
        {
            b[i] = new int[a.Length];
            for (var j = 0; j < b[i].Length - 1; j++)
            {
                b[i][j] = b[i - 1][j + 1];
            }
            b[i][b[i].Length - 1] = b[i - 1][0];
        }

        foreach(var i in b)
        {
            foreach(var j in i)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}