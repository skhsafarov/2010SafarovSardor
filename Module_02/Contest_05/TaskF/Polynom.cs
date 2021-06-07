using System;
using System.Linq;

class Polynom
{

    public static bool TryParsePolynom(string line, out int[] arr)
    {
        string[] a = line.Split(' ');
        string[] b = a.Where(x => int.TryParse(x, out int y)).ToArray();
        if (a.Length == b.Length)
        {
            arr = a.Select(x => int.Parse(x)).ToArray();
            return true;
        }
        else
        {
            arr = null;
            return false;
        }
    }

    public static int[] Sum(int[] a, int[] b)
    {
        int max = a.Length >= b.Length ? a.Length : b.Length;
        int min = max == a.Length ? b.Length : a.Length;
        int[] c = new int[max];
        for (int i = 0; i < max; i++)
        {
            c[i] += max == a.Length ? a[i] : b[i];
        }
        for (int i = 0; i < min; i++)
        {
            c[i] += min == b.Length ? b[i] : a[i];
        }
        return c;
    }

    public static int[] Dif(int[] a, int[] b)
    {
        return Sum(a, MultiplyByNumber(b, -1));
    }

    public static int[] MultiplyByNumber(int[] a, int n)
    {
        int[] c = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            c[i] = a[i] * n;
        }
        return c;
    }

    public static int[] MultiplyByPolynom(int[] a, int[] b)
    {
        int[] c = new int[a.Length + b.Length - 1];
        for (int i = 0; i < c.Length; i++)
        {
            for (int j = 0; j < a.Length; j++)
            {
                for (int k = 0; k < b.Length; k++)
                {
                    if (j + k == i)
                    {
                        c[i] += a[j] * b[k];
                    }
                }
            }
        }
        return c;
    }

    public static string PolynomToString(int[] polynom)
    {
        var a = polynom.Select(x => x.ToString()).ToArray();
        for (var i = 0; i < a.Length; i++)
        {
            if (a[i] == "0")
            {
                a[i] = null;
            }
            else if (a[i] == "1")
            {
                if (i == 0)
                {
                    a[i] = "1";
                }
                else if (i == 1)
                {
                    a[i] = "x";
                }
                else
                {
                    a[i] = "x" + i.ToString();
                }
            }
            else
            {
                if (i == 1)
                {
                    a[i] += "x";
                }
                else if (i != 0)
                {
                    a[i] += "x" + i.ToString();
                }
            }
        }

        Array.Reverse(a);
        var b = a.Where(x => x != null).ToArray();
        if (b.Length != 0)
        {
            var c = String.Join(" + ", b);
            return c;
        }
        else
        {
            return "0";
        }
    }
}