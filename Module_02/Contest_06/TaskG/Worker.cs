using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

public class Worker
{
    public Apple[] Apples { get; set; }
    public Worker(Apple[] apples)
    {
        Apples = apples;
    }

    public Apple[] GetSortedApples()
    {
        Array.Sort(Apples, new SortByWeight());
        return Apples;
    }
}
public class SortByWeight : IComparer<Apple>
{
    public int Compare(Apple o1, Apple o2)
    {
        return o1.Weight.CompareTo(o2.Weight);
    }
}