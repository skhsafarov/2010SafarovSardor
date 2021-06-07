using System;
using System.Linq;

partial class Program
{
    private static double GetMin(double[] array)
    {
        return array.Min();
    }

    private static double GetAverage(double[] array)
    {
        return array.Average();
    }

    private static double GetMedian(double[] array)
    {
        Array.Sort(array);
        if (array.Length % 2 == 0)
        {
            return (array[((array.Length) / 2) - 1] + array[array.Length / 2]) / 2;
        }
        else
        {
            return array[(int)(array.Length / 2)];
        }
    }
    
    private static double[] ReadNumbers(string line)
    {
        double[] mas = line.Split(' ').Select(x => double.Parse(x)).ToArray();
        return mas;
    }
    
}