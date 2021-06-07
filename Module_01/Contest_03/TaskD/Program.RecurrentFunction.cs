using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

partial class Program
{
    private static bool Validate(string input, out int num)
    {
        bool asd = int.TryParse(input, out num);
        bool asd1 = num >= 0;
        if(asd && asd1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static int RecurrentFunction(int n)
    {
        int b0 = 3;
        int res = b0;
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                res = 2 * (res + 1);
            }
        }
        return res;
    }
}