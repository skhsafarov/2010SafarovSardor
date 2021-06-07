using System;

namespace Task_03
{
    class Program
    {
        //Введя значения коэффициентов А, В, С, вычислить
        //корни квадратного уравнения.Учесть(как хотите)
        //возможность появления комплексных корней. Оператор
        //if не применять.
        static void dis(ref double a, ref double b, ref double c, ref double D, out double x1, out double x2)
        {
            D = b * b - 4 * a * c;
            x1 = (-b + Math.Sqrt(D)) / (2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);
            a++;
        }

        static void Main(string[] args)
        {
            double A, B, C, D, x1, x2;
            string J, K, L;
            do
            {
                Console.WriteLine("A = ");
                double.TryParse(Console.ReadLine(), out A);
                Console.WriteLine("B = ");
                double.TryParse(Console.ReadLine(), out B);
                Console.WriteLine("C = ");
                double.TryParse(Console.ReadLine(), out C);
                D = B * B - 4 * A * C;
                K = "Не имеет решений!";
                L = "Ответ:";
                J = D < 0 ? K : L;
                Console.WriteLine(J);
            } while (D < 0);
            dis(ref A, ref B, ref C, ref D, out x1, out x2);
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
    }
}
