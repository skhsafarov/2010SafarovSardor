using System;

partial class Program
{
    
    static int Factorial(int value)
    {
        int factorial = 1;
        for (int i = 2; i <= value; i++)
        {
            factorial = factorial * i;
        }
        return factorial;
    }

    static bool IsInputNumberCorrect(int number)
    {
        bool asd;
        if (number >= 0)
        {
            asd = true;
        }
        else
        {
            asd = false;
        }
        return asd;
    }
}