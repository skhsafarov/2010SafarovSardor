using System;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    public Point(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override bool Equals(object obj) =>
        obj is Point asd
        && asd.X == X
        && asd.Y == Y && asd.Z == Z;

   /* public override int GetHashCode()
    {
        throw new NotImplementedException();
    }*/

    public override string ToString()
    {
        return $"{X} {Y} {Z}";
    }
}