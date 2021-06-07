using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;

public class Example
{
    public static void Main()
    {
        var pathToDatabase = "db.txt";
        var queryParameters = "query.txt";
        var asd = queryParameters[2];


        string[] a = File.ReadAllLines(pathToDatabase).ToArray();
        string[][] b = new string[a.Length][];
        for(int i = 0; i < a.Length; i++)
        {
            b[i] = a[i].Split(';');
        }

    }
}