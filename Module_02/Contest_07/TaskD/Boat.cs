using System;

class Boat
{
    public int Value;
    public bool IsAtThePort { get; set; }
    public Boat(int value, bool isAtThePort)
    {
        Value = value;
        IsAtThePort = isAtThePort;
    }


    public int CountCost(int weight)
    {
        return weight * Value;
    }
}


