using System;

public static class Circle
{
    public static double Circumference(double radius)
    {
        return (radius * 2 * Math.PI);
    }

    public static double Square(double radius)
    {
        return Math.PI * radius * radius;
    }

    public static double Distance(double x1, double y1, double r1, double x2, double y2, double r2)
    {
        return Math.Pow((Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)), (1 / 2.0)) - r1 - r2;
    }
}