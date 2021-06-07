using System;

namespace Bulls_and_Cows
{
    partial class Program
    {
        // Сравнение заданного и введенного чисел 
        public static int BullsAndСows(int[] a, int[] b, int[,] d)
        {
            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (a[i] == b[j])
                    {
                        d[k, 1] = a[i];
                        if (i == j)
                            d[k, 0] = 2;
                        else
                            d[k, 0] = 1;
                        k++;
                    }
                }
            }
            return k;
        }
    }
}
