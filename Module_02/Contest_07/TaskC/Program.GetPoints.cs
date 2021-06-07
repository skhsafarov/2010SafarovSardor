using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public partial class Program
{
    /// <summary>
    /// Считывает точки в список.
    /// </summary>
    /// <returns>Список точек.</returns>
    private static List<Point> GetPoints()
    {
        var a = File.ReadAllLines(InputPath);
        var b = new List<Point>();
        foreach (var i in a)
        {
            var c = i.Split(' ').ToArray().Select(x => int.Parse(x)).ToArray();
            b.Add(new Point(c[0], c[1], c[2]));
        }
        return b;
    }


    /// <summary>
    /// Получает коллекцию уникальных точек.
    /// </summary>
    /// <param name="points">Список исходных точек.</param>
    /// <returns>Коллекция точек.</returns>
    private static HashSet<Point> GetUnique(List<Point> points)
    {
        var a = new HashSet<Point>();
        foreach (var i in points)
        {
            bool asd = true;
            foreach (var j in a)
            {
                if (i.Equals(j))
                {
                    asd = false;
                }
            }
            if (asd)
            {
                a.Add(i);
            }
        }
        return a;
    }
}