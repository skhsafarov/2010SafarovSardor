using System;
using System.Collections.Generic;
using System.Text;

namespace Bulls_and_Cows
{
    partial class Program
    {
        // Сравнение на чистое совпадение
        static bool NumberCompare(int[] a, int[] b)
        {
            bool d = true;
            for (int i = 0; i < 4; i++)
            {
                if (a[i] != b[i])
                {
                    d = false;
                    break;
                }
            }
            return d;
        }

    }
}
