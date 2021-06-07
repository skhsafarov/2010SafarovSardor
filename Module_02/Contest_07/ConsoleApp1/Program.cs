using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Ass2(5);
        }
    }

    class Ass2: Ass1
    {
        public Ass2(int a): base(a)
        {
            Console.WriteLine(a+1);
        }
        public Ass2()
        {
            Console.WriteLine("2");
        }
    }

    internal class Ass1
    {
        public Ass1(int a)
        {
            Console.WriteLine(++a);
        }
        public Ass1()
        {
            Console.WriteLine("1");
        }
    }
}
