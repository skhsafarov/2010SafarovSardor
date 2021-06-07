using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            var a = new int[n][];
            for (int i = 0; i < n; i++)
            {
                a[i] = NewMethod1(i);
            }

            foreach (var i in a)
            {
                foreach (var j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[] NewMethod1(int n)
        {
            int[] result = new int[n + 1];
            result[0] = 1;
            for (int i = 1; i < n + 1; i++)
            {
                int left = 0;
                for (int j = 0; j <= i; j++)
                {
                    int tmp = result[j];
                    result[j] += left;
                    left = tmp;
                }
            }
            return result;
        }
    }
}
