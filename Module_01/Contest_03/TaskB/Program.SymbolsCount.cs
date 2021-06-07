using System.Linq;

partial class Program
{
    private static void GetLetterDigitCount(string line, out int digitCount, out int letterCount)
    {
        char[] a = new char[line.Length];
        a = line.ToCharArray().Select(x => x).ToArray();
        digitCount = 0;
        letterCount = 0;
        for(int i = 0; i < a.Length; i++)
        {
            if (a[i] >= '0' && a[i] <= '9')
            {
                digitCount++;
            }
            else if ((a[i] >= 'A' && a[i] <= 'Z') || (a[i] >= 'a' && a[i] <= 'z'))
            {
                letterCount++;
            }
        }
    }
}