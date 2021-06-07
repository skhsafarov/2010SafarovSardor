using System;

public class Apple
{
    private double weight;
    private string color;
    
    public double Weight
    {
        get { return weight; }
        set
        {
            if (!Prov1(value))
            {
                throw new ArgumentException("Incorrect input");
            }
            weight = value;
        }
    }
public string Color
    {
        get
        {
            return color;
        }
        set
        {
            if (!Prov(value))
            {
                throw new ArgumentException("Incorrect input");
            }
            color = value;
        }
    }
    private bool Prov1(double a)
    {
        bool asd = false;
        if (a <= 1000 && a > 0)
        {
            asd = true;
        }
        return asd;
    }
    private bool Prov(string a)
    {
        var b = a.ToCharArray();
        bool asd = false;
        if (b.Length <= 5 && b[0] >= 'A' && b[0] <= 'Z')
        {
            asd = true;
        }
        return asd;
    }
    public override string ToString()
    {
        return $"{Color} Apple. Weight = {Weight:f2}g.";
    }
}