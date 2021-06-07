using System;

namespace Task_01
{
    class Program
    {
        /*Ввести значение x и вывести значение полинома:
        F(x) = 12x4 + 9x3 - 3x2 + 2x – 4.
        Не применять возведение в степень.
        Использовать минимальное количество операций умножения.*/

        public static void Polinom(ref double a, out double b)
        {
            b = (12 * a * a * a * a ) + 9 * a * a * a - 3 * a * a + 2 * a - 4;
        }

        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите x: ");
            double.TryParse(Console.ReadLine(), out x);
            Polinom(ref x, out y);
            Console.WriteLine("y= " + y);
        }
    }
}
