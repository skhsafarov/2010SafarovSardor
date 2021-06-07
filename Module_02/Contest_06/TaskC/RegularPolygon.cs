using System;

public class RegularPolygon : Polygon
{
    private double side;
    private int numberOfSides;
    public RegularPolygon(double side, int numberOfSides)
    {
        if (side<=0)
        {
            throw new ArgumentException("Side length value should be greater than zero.");
        }
        else if (numberOfSides<3)
        {
            throw new ArgumentException("Number of sides value should be greater than 3.");
        }
        this.side = side;
        this.numberOfSides = numberOfSides;
    }

    public override double Perimeter => side * numberOfSides;

    public override double Area => 0.25 * numberOfSides * Math.Pow(side, 2) * Math.Pow(Math.Tan(Math.PI / numberOfSides), -1);

    public override string ToString() => $"side: {side}; numberOfSides: {numberOfSides}; area: {Area:f3}; perimeter: {Perimeter:f3}";
}