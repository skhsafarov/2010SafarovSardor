using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 6;
            for (int a = 7; summa % 111 != 0 && summa < 1000; a++)
            {
                summa = a + summa;
                if (summa % 111 == 0)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(summa);
                    string l = (a - 2).ToString();
                    string m = (a - 1).ToString();
                    Console.WriteLine($"1+2+3...+{l}+{m}+{a}= {summa}");
                    break;
                }
            }
        }
    }  
}
