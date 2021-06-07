using System;
using System.Linq;

partial class Program
{
    private static int GetCountGreaterThanValue(int[] array, double average)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > average)
            {
                sum++;
            }
        }
        return sum;
    }

    private static double GetAverage(int[] array)
    {
        double a = array.Average();
        return a;
    }

    private static bool ValidateNumber(out int n)
    {
        bool asd = int.TryParse(Console.ReadLine(), out n);
        if (asd && n >= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static bool ReadNumbers(int n, out int[] array)
    {
        bool asd = true;
        if (n>0)
        {
            array = new int[n];
            for (int i = 0; i < n; i++)
            {
                if(!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    return false;
                }
            }
        }
        else
        {
            array = new int[1];
            array[0] = 0;
        }

        if (array.Min() >= 0 && asd)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}