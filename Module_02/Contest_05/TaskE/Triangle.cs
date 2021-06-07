using System;

public class Triangle
{
    private readonly Point a;
    private readonly Point b;
    private readonly Point c;

    private double AB => GetLengthOfSide(a, b);
    private double AC => GetLengthOfSide(a, c);
    private double BC => GetLengthOfSide(b, c);

    public Triangle(Point a, Point b, Point c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double GetPerimeter()
    {
        return AB + AC + BC;
    }

    public double GetSquare()
    {
        double p = (AB + AC + BC) / 2d;
        return Math.Sqrt(p * (p - AB) * (p - AC) * (p - BC));
    }

    public bool GetAngleBetweenEqualsSides(out double angle)
    {
        bool asd = false;
        double res = 0;
        if(AB == AC)
        {
            res = GetAngele(BC, AB, AC);
            asd = true;
        }
        else if (AB == BC)
        {
            res = GetAngele(AC, BC, AB);
            asd = true;
        }
        else if(AC == BC)
        {
            res = GetAngele(AB, BC, AC);
            asd = true;
        }
        
        angle = res;
        return asd;
    }

    public double GetAngele(double a, double b, double c)
    {
        return (double)Math.Acos((b * b + c * c - a * a) / (2 * b * c));
    }

    public bool GetHypotenuse(out double hypotenuse)
    {
        if (Math.Sqrt(AC * AC + BC * BC) == AB)
        {
            hypotenuse = Math.Sqrt(AC * AC + BC * BC);
            return true;
        }
        else if (Math.Sqrt(AB * AB + BC * BC) == AC)
        {
            hypotenuse = Math.Sqrt(AB * AB + BC * BC);
            return true;
        }
        else if(Math.Sqrt(AB * AB + AC * AC) == BC)
        {
            hypotenuse = Math.Sqrt(AB * AB + AC * AC);
            return true;
        }
        else
        {
            hypotenuse = 0;
            return false;
        }
    }

    private static double GetLengthOfSide(Point first, Point second)
    {
        return Math.Sqrt(Math.Pow(second.GetX() - first.GetX(), 2) + Math.Pow(second.GetY() - first.GetY(), 2));
    }
}