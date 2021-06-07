using System;
using System.Collections.Generic;
using System.Text;

partial class Program
{
    static int[][] GetBellTriangle(uint rowCount)
    {

        var a = new int[rowCount][];
        a[0] = new int[] { 1 };
        for (int i = 1; i < rowCount; i++)
        {
            a[i] = new int[i + 1];
            a[i][0] = a[i - 1][a[i - 1].Length - 1];
            for (var j = 1; j < a[i].Length; j++)
            {
                a[i][j] = a[i][j - 1] + a[i - 1][j - 1];
            }
        }
        return a;

    }

    private static void PrintJaggedArray(int[][] array)
    {
        for (var i = 0; i < array.Length; i++)
        {
            for (var j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j] + " ");
            }
            Console.WriteLine();
        }

    }
}

