using System;

partial class Program
{
    // В случае, если введённый день недели не соответствует формату входных данных
    // метод должен вернуть int.MinValue.
    // Гарантируется, что int.MinValue не может быть получен как верный ответ.
    static int MorningWorkout(string dayOfWeek, int x, int y)
    {
        int result = 0;
        if ((dayOfWeek == "Monday" || dayOfWeek == "Wednesday" || dayOfWeek == "Friday"))
        {
            result = GetSumOfOddOrEvenDigits(x, 1);
        }
        else if ((dayOfWeek == "Tuesday" || dayOfWeek == "Thursday"))
        {
            result = GetSumOfOddOrEvenDigits(y, 2);
        }
        else if (dayOfWeek == "Saturday")
        {
            result = Maximum(x, y);
        }
        else if (dayOfWeek == "Sunday")
        {
            result = Multiply(x, y);
        }
        else
        {
            result = int.MinValue;
        }
        return result;
    }

    static int GetSumOfOddOrEvenDigits(int value, int r)
    {
        int n;
        int sum = 0;
        while (value != 0)
        {
            n = value % 10;
            if (r == 1)
            {
                if (n % 2 != 0)
                {
                    sum = sum + n;
                }
                value = value / 10;
            }
            else if (r == 2)
            {
                if (n % 2 == 0)
                {
                    sum = sum + n;
                }
                value = value / 10;
            }
        }
        return Math.Abs(sum);
    }


    static int Multiply(int firstValue, int secondValue)
    {
        return firstValue * secondValue;
    }

    static int Maximum(int firstValue, int secondValue)
    {
        return Math.Max(firstValue, secondValue);
    }
}