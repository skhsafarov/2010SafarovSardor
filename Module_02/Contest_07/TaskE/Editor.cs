using System;
using System.Collections.Generic;
using System.Linq;

abstract class Editor
{
    public string Name { get; set; }
    public int Salary { get; set; }
    protected Editor(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }

    protected string EditHeader(string header)
    {
        return $"{header} {Name}";
    }

    public int CountSalary(string oldStr, string newStr)
    {
        var a = oldStr.ToCharArray().ToList();
        var b = newStr.ToCharArray().ToList();
        for (int i = 0; i < b.Count; i++)
        {
            for (int j = 0; j <a.Count; j++)
            {
                if (b[i] == a[j])
                {
                    a.RemoveAt(j);
                    break;
                }
            }
        }
        return a.Count;
    }
}