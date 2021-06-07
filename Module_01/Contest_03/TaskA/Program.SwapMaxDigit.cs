using System;
using System.Linq;

partial class Program
{
    private static bool TryParseInput(string inputA, string inputB, out int a, out int b)
    {
        bool asd1 = int.TryParse(inputA, out a);
        bool asd2 = int.TryParse(inputB, out b);
        bool asd3 = a >= 0 && b >= 0;
        if (asd1 && asd2 && asd3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static void SwapMaxDigit(ref int a, ref int b)
    {
        int[] asd = new int[a.ToString().Length];
        int[] bsd = new int[b.ToString().Length];
        for (int i = 0; i <= (asd.Length) - 1; i++)
        {
            asd[i] = a % 10;
            a = a / 10;
        }
        for (int i = 0; i <= (bsd.Length) - 1; i++)
        {
            bsd[i] = b % 10;
            b = b / 10;
        }
        int maxA = asd.Max();
        int maxB = bsd.Max();
        Array.Reverse(asd);
        Array.Reverse(bsd);
        for (int i = 0; i <= (asd.Length) - 1; i++)
        {
            if(asd[i] == maxA)
            {
                asd[i] = maxB;
            }
        }
        for (int i = 0; i <= (bsd.Length) - 1; i++)
        {
            if (bsd[i] == maxB)
            {
                bsd[i] = maxA;
            }
        }
        char[] x = asd.Select(x => (char)(x + '0')).ToArray();
        char[] y = bsd.Select(x => (char)(x + '0')).ToArray();
        a = int.Parse(String.Join("", x));
        b = int.Parse(String.Join("", y));
    }
}