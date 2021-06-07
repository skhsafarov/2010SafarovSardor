using System;
using System.Linq;

public partial class Program
{
    static bool IsArrayLengthCorrect(int length)
    {
        if(length>0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static bool GenerateArray(int length, out int[] arr)
    {
        arr = new int[length];
        bool res = true;
        for(var i = 0; i < arr.Length; i++)
        {
            bool asd = int.TryParse(Console.ReadLine(), out arr[i]);
            if(!asd)
            {
                res = false;
            }
        }
        return res;
    }

    public static double GetArrayAverage(int[] arr)
    {
        return arr.Average();
    }

    public static int GetSumOfNumbersLessThanAverage(int[] arr, double average)
    {
        int sum = 0;
        for(int i = 0; i<arr.Length; i++)
        {
            if (arr[i] < average)
            {
                sum = sum + arr[i];
            }
        }
        return sum;
    }
}
