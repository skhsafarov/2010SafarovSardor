using System;

namespace Task_04
{
    class Program
    {
        //Получить от пользователя четырехзначное натуральное
        //число и напечатать его цифры в обратном порядке.

        static void Main(string[] args)
        {
            uint a, a1, a2, a3, a4;
            do
            {
                Console.WriteLine("Введите четырехзначное натуральное числож: ");
                uint.TryParse(Console.ReadLine(), out a);
            } while (!(a>=1000 && a<=9999));
            a1 = a / 1000;
            a2 = (a - a1*1000) / 100;
            a3 = (a - a1*1000 - a2*100) / 10;
            a4 = a - a1*1000 - a2*100 - a3*10;
            a = a4 * 1000 + a3 * 100 + a2 * 10 + a1;
            Console.WriteLine(a);
        }
    }
}
