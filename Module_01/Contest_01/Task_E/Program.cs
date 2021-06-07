using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_E
{
    class Program
    {
        static void Main(string[] args)
        {
            string sa = Console.ReadLine();
            uint a, b, c, d, e;
            bool asd = uint.TryParse(sa, out a);
            b = a / 1000;
            c = (a / 100) % 10;
            d = (a / 10) % 10;
            e = (a % 10);
            if (asd && a > 999 && a < 10000)
            {
                if(b == e && c == d)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
