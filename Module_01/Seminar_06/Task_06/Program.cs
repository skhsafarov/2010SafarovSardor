using System;
using System.Globalization;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Random ran = new Random();
            int[][] asd = new int[n][];
            for (int i = 0; i < asd.Length; i++)
            {
                asd[i] = new int[ran.Next(3, 8)];
            }
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < asd[j].Length; k++)
                {
                    asd[j][k] = ran.Next(-10, 11);
                }
            }
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < asd[j].Length; k++)
                {
                    Console.Write(asd[j][k]+"\t");
                }
                Console.WriteLine();
            }
        }      
    }
}
