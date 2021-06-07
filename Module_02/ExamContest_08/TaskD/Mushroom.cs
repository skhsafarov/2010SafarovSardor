using System;
using System.Collections.Generic;

public class Mushroom
{
    private string Name { get; }
    private double Weight { get; }
    private double Diameter { get; }

    private Mushroom(string name, double weight, double diameter)
    {
        if ((diameter <= 0) || (weight <= 0))
            throw new ArgumentException("Incorrect input");

        Name = name;
        Weight = weight;
        Diameter = diameter;
    }

    public static Mushroom Parse(string line)
    {
        double Mush1;
        double Mush2;

        string[] arr = line.Split(' ');
        if ((!double.TryParse(arr[1], out Mush1)) || (!double.TryParse(arr[2], out Mush2)))
            throw new ArgumentException("Incorrect input");
        return new Mushroom(arr[0], Mush1, Mush2);
    }

    public static double GetAverageDiameter(List<Mushroom> mushrooms, double m)
    {
        double currentCount = 0;
        double totalSum = 0;

        for (int i = 0; i < mushrooms.Count; i++)
        {
            if (mushrooms[i].Weight > m)
            {
                currentCount++;
                totalSum = totalSum + mushrooms[i].Diameter;
            }
        }
        if (currentCount == 0)
            return 0;

        double result = totalSum / currentCount;
        return result;
    }
}


/*using System;
using System.Collections.Generic;

public class Mushroom
{
    private string Name { get; }
    private double Weight { get; }
    private double Diameter { get; }

    private Mushroom(string name, double weight, double diameter)
    {
    }

    public static Mushroom Parse(string line)
    {
        throw new NotImplementedException();
    }

    public static double GetAverageDiameter(List<Mushroom> mushrooms, double m)
    {
        throw new NotImplementedException();
    }
}*/