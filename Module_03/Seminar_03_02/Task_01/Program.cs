using System;
using System.Collections.Generic;
using System.Linq;



namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Делегаты Action, Predicate и Func, Converter, Comparison
            Action action1 = () => Console.WriteLine("action1");
            action1();
            Action<int> action2 = (a) => Console.WriteLine("action2" + a);
            action2(10);
            Action<int, double> action3 = (a, b) => Console.WriteLine("action3" + a * b);
            action3(10, 5.5);



            int[] arr1 = { -10, 5, 6, 3, 4, -7 };
            Array.ForEach(arr1, a => Console.Write(a + " "));
            Console.WriteLine();



            Predicate<int> predicate = delegate (int a)
            {
                return a % 2 == 0;
            };
            Console.WriteLine(predicate(10));
            Console.WriteLine(predicate(11));



            Func<int, int> func1 = (a) => a * a;
            Console.WriteLine(func1(10));
            Func<int, double, double> func2 = (a, b) => a * b;
            Console.WriteLine(func2(10, 5.5));
            Func<double, int> func3 = (a) => (int)a;
            Console.WriteLine(func3(5.5));



            Converter<int, int> converter1 = (a) => a + 10;
            Console.WriteLine(converter1(5));
            Converter<double, int> converter2 = (a) => (int)a;
            Console.WriteLine(converter2(55.7));



            int[] arr2 = { -10, 5, 6, 3, 4, -7 };
            int[] arr3 = Array.ConvertAll(arr2, converter1);
            Array.ForEach(arr2, a => Console.Write(a + " "));
            Console.WriteLine();
            Array.ForEach(arr3, a => Console.Write(a + " "));
            Console.WriteLine();
            int[] arr4 = { -10, 5, 6, 3, 4, -7 };
            int[] arr5 = Array.ConvertAll(arr4, a => a % 3);
            Array.ForEach(arr4, a => Console.Write(a + " "));
            Console.WriteLine();
            Array.ForEach(arr5, a => Console.Write(a + " "));



            Comparison<int> comparison1 = (a, b) =>
            {
                if (a < b) return 1;
                if (a > b) return -1;
                return 0;
            };
            Comparison<int> comparison2 = (a, b) =>
            {
                return (b - a);
            };
            int[] arr6 = { -10, 5, 6, 3, 4, -7 };
            int[] arr7 = { -10, 5, 6, 3, 4, -7 };
            Array.Sort(arr6, comparison1);
            Array.Sort(arr7, comparison2);
            Array.ForEach(arr6, a => Console.Write(a + " "));
            Console.WriteLine();
            Array.ForEach(arr7, a => Console.Write(a + " "));
            Console.WriteLine();



            int[] arr8 = { -10, 5, 6, 3, 4, -7 };
            int[] arr9 = { 10, 5, 6, 3, 4, 7 }; // 10 6 4 5 3 7
            Array.Sort(arr8, (a, b) => (a - b));
            Array.Sort(arr9, (a, b) =>
            {
                if (a % 2 == 1 && b % 2 == 0) return 1;
                else return -1;
            });
            Array.ForEach(arr8, a => Console.Write(a + " "));
            Console.WriteLine();
            Array.ForEach(arr9, a => Console.Write(a + " "));
            Console.WriteLine();
        }
    }
}