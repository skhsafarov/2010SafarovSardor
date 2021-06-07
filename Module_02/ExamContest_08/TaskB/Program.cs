using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        var a = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
        var b = a.Sum() / a.Length;
        Console.WriteLine($"{b:f3}");
    }
}