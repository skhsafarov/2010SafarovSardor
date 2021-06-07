using System.IO;

public static partial class Program
{
    private static int GetCountCapitalLetters(string inputPath)
    {
        char[] str = File.ReadAllText(inputPath).ToCharArray();
        int sum = 0;
        for(int i =0; i<str.Length;i++)
        {
            if(str[i]>='A' && str[i]<='Z')
            {
                sum++;
            }
        }
        return sum;
    }

    private static void WriteCount(string outputPath, int count)
    {
        File.WriteAllText(outputPath, count.ToString());
    }
}