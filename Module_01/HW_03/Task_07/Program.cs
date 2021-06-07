using System;

namespace ConsoleApp1
{
    class Program
    {
        static bool Sector(double x, double y)
        {
            if (x >= 0 && y <= x && (x * x + y * y <= 4))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            double x, y;
            string xs, ys;
            xs = Console.ReadLine(); //Ввод данных.
            ys = Console.ReadLine();
            if (double.TryParse(xs, out x) && double.TryParse(ys, out y)) //Проверка данных.
            {
                Console.WriteLine(Sector(x, y)); //Вывод результата с помощью метода.
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}