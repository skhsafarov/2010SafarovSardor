using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] a = new string[] { "asd", "das" };
        a[0] = null;
        string[] b = a.Where(x => x!=null).ToArray();
        Console.WriteLine(b.Length);
    }
}