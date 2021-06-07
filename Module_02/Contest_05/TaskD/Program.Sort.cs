using System;
using System.Linq;

public partial class Program
{
    static bool ParseArrayFromLine(string line, out int[] arr)
    {
        bool asd = false;
        arr = null;
        var a = line.Split(' ').ToArray();
        var b = a.Where(x => int.TryParse(x, out int y)).ToArray();
        if (a.Length == b.Length)
        {
            arr = a.Select(x => int.Parse(x)).ToArray();
            asd = true;
        }
        return asd;
    }

    private static void Merge(int[] arr, int left, int right, int mid)
    {
        Array.Sort(arr);
    }
}