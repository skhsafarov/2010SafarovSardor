using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("A = ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("B = ");
            int.TryParse(Console.ReadLine(), out B);
            
            C = A * A + B * B;
            
            Console.WriteLine("C = "+Math.Sqrt(C));
        }
    }
}
