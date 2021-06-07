using System;

public abstract class Function
{
    public static Function GetFunction(string functionName)
    {
        if (functionName == "Sin")
        {
            return new Sin();
        }
        else if (functionName == "Exp")
        {
            return new Exponent();
        }
        else if (functionName == "Parabola")
        {
            return new Parabola();
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }
    }

    public abstract double GetValueInX(double x);

    public static double SolveIntegral(Function func, double left, double right, double step)
    {
        double summa = 0;
        for (double x = left; x < right; x += step)
        {
            summa += func.GetValueInX(x);
        }
        return summa;
    }
}
