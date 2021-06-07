using System;
using System.Collections.Generic;
#pragma warning disable

public class ArchaeologicalFind
{
    public int Age { get; set; }
    public int Weight { get; set; }
    public string Name { get; set; }
    public int Id { get; set; }

    internal static int TotalFindsNumber;

    public ArchaeologicalFind(int age, int weight, string name)
    {
        if (age <= 0)
        {
            throw new ArgumentException("Incorrect age");
        }
        else if (weight <= 0)
        {
            throw new ArgumentException("Incorrect weight");
        }
        else if (name == "?")
        {
            throw new ArgumentException("Undefined name");
        }
        Age = age;
        Weight = weight;
        Name = name;
        Id = TotalFindsNumber;
    }
    /// <summary>
    /// Добавляет находку в список.
    /// </summary>
    /// <param name="finds">Список находок.</param>
    /// <param name="archaeologicalFind">Находка.</param>
    public static void AddFind(ICollection<ArchaeologicalFind> finds, ArchaeologicalFind archaeologicalFind)
    {
        if (Equals(finds, archaeologicalFind))
        {
            finds.Add(archaeologicalFind);
        }
        TotalFindsNumber++;
    }


    private static bool Equals(ICollection<ArchaeologicalFind> finds, ArchaeologicalFind archaeologicalFind)
    {
        foreach (var i in finds)
        {
            if (archaeologicalFind.Name == i.Name && archaeologicalFind.Age == i.Age && archaeologicalFind.Weight == i.Weight)
            {
                return false;
            }
        }
        return true;
    }

    public override string ToString()
    {
        return $"{Id} {Name} {Age} {Weight}";
    }
}