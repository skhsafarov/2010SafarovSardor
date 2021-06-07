using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine(123);
            for (int i = 1; i <= 12345678; i++)
            {
                if (Asd1(i) && Asd2(i))
                {
                    count++;
                    Console.WriteLine($"{ count} - {i}");
                }
            }
            Console.WriteLine(count);
        }
        public static bool Asd1(int a)
        {
            bool asd = true;
            var b = a.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
            if (b.Length > 1)
            {
                for (int i = 0; i < b.Length - 1; i++)
                {
                    int a1 = b[i];
                    int a2 = b[i + 1];
                    if (a1 >= a2)
                    {
                        asd = false;
                        break;
                    }
                }
            }
            return asd;
        }
        public static bool Asd2(int a)
        {
            bool asd = true;
            string b = a.ToString();
            if (b.Contains("1234") || b.Contains("2345") || b.Contains("3456") || b.Contains("4567") || b.Contains("5678") || b.Contains("9") || b.Contains("0"))
            {
                asd = false;
            }
            return asd;
        }
    }
}
