using System;
using System.Linq;

partial class Program
{
    private static int[] ParseInput(string input)
    {    
        int[] mas = input.Split(' ').Select(x => int.Parse(x)).ToArray();
        return mas;
    }

    private static int GetMaxInArray(int[] numberArray)
    {
        return numberArray.Max();
    }
}