using System;

namespace Bulls_and_Cows
{
    partial class Program
    {
        static void Main()
        {
            do
            {
                Console.WriteLine("Игра_Быки_и_Коровы\n");
                Console.WriteLine("Введите число попыток: ");
                int NmaxAnswers = int.Parse(Console.ReadLine()); // число попыток
                int[] a = new int[4];  // загадываемое число
                int[] b = new int[4];  // Ваш ответ
                GenSetN(4, 10, a);
                int nAnswers = 1;
                while (nAnswers <= NmaxAnswers)
                {
                    if (Answer(b))  // ответ
                        if (NumberCompare(a, b))
                        {
                            Console.WriteLine("Вы угадали число c {0} попытки!", nAnswers);
                            Console.WriteLine("\nИГРА ЗАВЕРШЕНА!\nЧТОБЫ НАЧАТЬ ЗАНОВО НАЖМИТЕ ЛЮБУЮ КНОПКУ!\nЧТОБЫ ВЫЙТИ НАЖМИТЕ ESC!\n");
                            if (Console.ReadKey(true).Key != ConsoleKey.Escape)
                            {
                                Main();
                            }
                            else
                            {
                                return; ;
                            }
                        }
                    int[,] d = new int[4, 2];
                    // угаданная цифра d[i,1], бык(d[i,0]=2) корова(d[i,0]=1)
                    // АНАЛИЗ. n - число угаданных цифр
                    int n = BullsAndСows(a, b, d);
                    for (int i = 0; i < n; i++)
                    {
                        if (d[i, 0] == 1)
                            Console.WriteLine("КОРОВА ({0})", d[i, 1]);
                        else
                            Console.WriteLine("БЫК ({0})", d[i, 1]);
                    }
                    if (n == 0)
                        Console.WriteLine("В Вашем числе нет загаданных цифр");
                    nAnswers++;
                }
                Console.WriteLine("\nИГРА ЗАВЕРШЕНА!\nЧТОБЫ НАЧАТЬ ЗАНОВО НАЖМИТЕ ЛЮБУЮ КНОПКУ!\nЧТОБЫ ВЫЙТИ НАЖМИТЕ ESC!\n");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}