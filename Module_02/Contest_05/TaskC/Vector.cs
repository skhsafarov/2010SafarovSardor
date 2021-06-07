using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

partial class Program
{
    static bool TryParseVectorFromFile(string filename, out int[] vector)
    {
        bool asd = false;
        vector = null;
        string[] b;
        string[] c;
        var a = File.ReadAllLines(filename);
        if (a.Length == 1)
        {
            b = a[0].Split(' ').ToArray();
            c = b.Where(x => int.TryParse(x, out int y)).ToArray();
            if (c.Length == b.Length)
            {
                vector = c.Select(x => int.Parse(x)).ToArray();
                asd = true;
            }
        }
        return asd;
    }

    static int[,] MakeMatrixFromVector(int[] vector)
    {
        {
            var a = new int[vector.Length, 1];
            var b = new int[1, vector.Length];
            for (var v = 0; v < vector.Length; v++)
            {
                a[v, 0] = vector[v];
                b[0, v] = vector[v];
            }

            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }
    }

    static void WriteMatrixToFile(int[,] matrix, string filename)
    {
        File.Create(filename).Close();
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            File.AppendAllText(filename, matrix[i, 0].ToString());
            for (var j = 1; j < matrix.GetLength(1); j++)
            {
                File.AppendAllText(filename, " " + matrix[i, j].ToString());
            }
            File.AppendAllText(filename, "\n");
        }
    }
}