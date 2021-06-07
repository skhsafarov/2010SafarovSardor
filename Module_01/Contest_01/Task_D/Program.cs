using System;

namespace Task_D
{
    class Program
    {

        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            int a;
            bool asd = int.TryParse(str1, out a);
            string str2 = Console.ReadLine();
            int b;
            bool asda = int.TryParse(str2, out b);
            if (!asd || !asda)
            {
                Console.WriteLine("Incorrect input");
            }
            else if (b > a)
            {
                Console.WriteLine("Second");
            }
            else if (a == b)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("First");
            }
        }
    }
}
