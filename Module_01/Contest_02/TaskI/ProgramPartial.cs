using System;
using System.Collections.Generic;
using System.Text;

partial class Program
{

    // Проверка входных чисел на корректность
    static bool Validate(int a)
    {
        if (a > 0)
            return true;
        else
            return false;
    }

    static int GetPerfectNumber(int a)
    {
        int sum = 0;
        bool asd = true;
        for (int an = a; asd; an++)
        {
            int sumd = 0;
            for (int i = 1; i < an; i++)
            {
                if (an % i == 0)
                {
                    sumd = sumd + i;
                }

            }
            if (sumd == an)
            {
                asd = false;
                sum = sumd;
            }
        }
        return sum;
    }
}