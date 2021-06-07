using System;

class Brigantine : Boat
{
    public new int Value;
    public new bool IsAtThePort { get; set; }
    public Brigantine(int value, bool isAtThePort) : base(value, isAtThePort)
    {
        Value = value;
        IsAtThePort = isAtThePort;
    }

    public new int CountCost(int weight)
    {
        if (weight<=500)
        {
            return weight * Value * Value;
        }
        else
        {
            return weight * Value;
        }
    }
}