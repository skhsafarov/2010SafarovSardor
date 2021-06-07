using System;

namespace Task_02
{
    class Program
    {
        /*Ввести натуральное трехзначное число Р.
        Найти наибольшее целое число, которое можно
        получить, переставляя цифры числа Р.*/

        public static void Numerals(uint number, out uint c)
        {
            uint x, y, z, a1, a2, a3;
            x = number / 100;            // первая цифра
            uint temp = number - x * 100;
            y = temp / 10;             // вторая цифра
            z = temp - y * 10;        // третья цифра           
            a1 = x < y ? (z < x ? z : x) : (y < z ? y : z);
            a3 = x > y ? (z > x ? z : x) : (y > z ? y : z);
            a2 = x + y + z - a1 - a3;
            string b1, b2, b3;
            b3 = Convert.ToString(a1);
            b2 = Convert.ToString(a2);
            b1 = Convert.ToString(a3);
            c = Convert.ToUInt32(b1 + b2 + b3);
        }

        public static void Main(string[] args)
        {
            uint numb;
            do
            {
                do Console.Write("Введите натуральное трехзначное число Р: ");
                while (!uint.TryParse(Console.ReadLine(), out numb) ||
                               numb < 100 ||
                                     numb > 999);
                uint a;
                Numerals(numb, out a);
                Console.WriteLine("Наибольшее целое число = " + a);
                Console.WriteLine("Нажмите Escape для выхода");

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
