using System;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            Console.WriteLine("Введите число от 32 до 127:");
            t = Convert.ToInt32(Console.ReadLine());

            if(t>=32 && t<=127)
            {
                Console.WriteLine("Code = " + (char)t);
            }
            else
            {
                Console.WriteLine("Введите корректные данные!!!");
            }           
        }
    }
}