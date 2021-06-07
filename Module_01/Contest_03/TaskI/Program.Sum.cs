using System;
using System.IO;
using System.Linq;
using System.Text;

partial class Program
{
    private static string GetTextFromFile(string inputPath)
    {
        string str = File.ReadAllText(inputPath, Encoding.UTF8).ToString();
        return str;
    }

    private static int GetSumFromText(string text)
    {
        char[] a = {'\n', '.', '!', '?', ' ', ',' };
        String[] asd = text.Split(a).ToArray();
        int sum = 0;
        for(int i = 0; i < asd.Length; i++)
        {
            if(int.TryParse(asd[i], out int x))
            {
                sum = sum + x;
            }
        }
        return sum;
    }
}