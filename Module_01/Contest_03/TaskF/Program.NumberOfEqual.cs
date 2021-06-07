using System;
using System.Linq;

partial class Program
{
    private static int[] ParseInput(string input)
    {
        int[] mas = input.Split(' ').Select(x => int.Parse(x)).ToArray();
        return mas;
    }

    private static int GetNumberOfEqualElements(int[] first, int[] second)
    {
        int hasDuplicate = 0;

        foreach (var numberA in first)
        {
            foreach (var numberB in second)
            {
                if (numberA == numberB)
                {
                    hasDuplicate++;
                }
            }
        }
        return hasDuplicate;
    }
}