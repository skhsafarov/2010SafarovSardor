using System;

namespace Bulls_and_Cows
{
    partial class Program
    {

        // ответ пользователя (строка в число)
        static bool Answer(int[] b)
        {
            bool bb = true;
            string ss;
            int a;
            do
            {
                Console.WriteLine("Введите Ваше 4-значное число: ");
                ss = Console.ReadLine();
                a = ss.Length;
                if (a!=4)
                {
                    Console.WriteLine("Это не 4-значное число! ");
                }
            } while (a != 4);
            

            // посимвольная разборка
            for (int i = 0; i < 4; i++)
            {
                char c = ss[i];
                if (char.IsDigit(c))
                    b[i] = Convert.ToInt32(c - 48);
                else
                {
                    Console.WriteLine("Вы ввели НЕ 4-х значное число!");
                    bb = false;
                    return bb;
                }
            }
            return bb;
        }
    }
}
