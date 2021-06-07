using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            uint a = uint.Parse(Console.ReadLine());
            int[] asd = new int[a];
            Random random = new Random();
            for(int i = 0; i<a; i++)
            {
                asd[i] = random.Next(-10, 10);
                Console.WriteLine(asd[i]);
            }
            
        }
    }
}
