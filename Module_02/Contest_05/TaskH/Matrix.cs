using System;
using System.Globalization;
using System.IO;
using System.Linq;

internal class Matrix
{
    int[,] matrix;

    public Matrix(string filename)
    {
        var a = File.ReadAllLines(filename);
        matrix = new int[a.Length, a[0].Split(';').ToArray().Length];
        for (var i = 0; i < a.Length; i++)
        {
            var b = a[i].Split(';').Select(x => int.Parse(x)).ToArray();
            for (var j = 0; j < b.Length; j++)
            {
                matrix[i, j] = b[j];
            }
        }
    }

    public int SumOffEvenElements
    {
        get
        {
            int sum = 0;
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
    }

    public override string ToString()
    {
        string str = null;
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                str += matrix[i, j].ToString();
                if (j == matrix.GetLength(1) - 1)
                {
                    str += "\n";
                }
                else
                {
                    str += "\t";
                }
            }
        }
        return str;
    }
}