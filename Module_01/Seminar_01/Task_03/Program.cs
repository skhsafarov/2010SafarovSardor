using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Введите Вашу фамилию:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Ваше имя:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Введите Ваше отчество:");
            string name2 = Console.ReadLine();
            Console.WriteLine("\nИмя: " + name1 + "\nОтчество: "+name2+"\nФамилия: "+name);
            Console.ReadKey();
        }
    }
}
