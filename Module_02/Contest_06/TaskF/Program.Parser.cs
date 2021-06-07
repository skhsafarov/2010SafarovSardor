using System;


public partial class Program
{
    static Sheep ParseSheep(string line)
    {
        var arr = line.Split(' ');
        if (!int.TryParse(arr[4], out int a) || a >= 1000 || a <= 0)
        {
            throw new ArgumentException("Incorrect input");
        }
        return new Sheep(a, arr[1], arr[6]);
    }
}
