using System;
using System.Collections.Generic;

public class Grassland
{
    public List<Sheep> Sheeps { get; set; }
    public Grassland(List<Sheep> sheeps)
    {
        Sheeps = sheeps;
    }

    public List<Sheep> GetEvenSheeps()
    {
        List<Sheep> a = new List<Sheep>();
        foreach (var i in Sheeps)
        {
            if (i.Id%2 == 0)
            {
                a.Add(i);
            }
        }
        return a;
    }

    public List<Sheep> GetOddSheeps()
    {
        List<Sheep> a = new List<Sheep>();
        foreach (var i in Sheeps)
        {
            if (i.Id % 2 != 0)
            {
                a.Add(i);
            }
        }
        return a;
    }

    public List<Sheep> GetSheepsByContainsName(string name)
    {
        List<Sheep> a = new List<Sheep>();
        foreach ( var i in Sheeps)
        {
            if (i.Name.Contains(name))
            {
                a.Add(i);
            }
        }
        return a;
    }
}
