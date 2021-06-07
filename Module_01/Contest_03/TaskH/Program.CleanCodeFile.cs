using System.IO;
using System.Linq;
using System.Text;

partial class Program
{
    private static string[] ReadCodeLines(string codePath)
    {
        return File.ReadAllLines(codePath);
    }
    private static string[] CleanCode(string[] codeWithComments)
    {
        for (int i = 0; i < codeWithComments.Length; i++)
        {
            if (codeWithComments[i].Replace(" ", "").Replace("\t", "").StartsWith("//"))
            {
                codeWithComments[i] = "";
            }
            else if (codeWithComments[i].Replace(" ", "").Replace("\t", "").StartsWith("/*"))
            {
                if (!codeWithComments[i].Contains("*/"))
                {
                    bool asd1 = true;
                    for (int j = i; asd1; j++)
                    {
                        if (!codeWithComments[j].Contains("*/"))
                        {
                            codeWithComments[j] = "";
                        }
                        else if (codeWithComments[j].Contains("*/"))
                        {
                            codeWithComments[j] = "";
                            asd1 = false;
                        }
                    }
                }
                else
                {
                    codeWithComments[i] = "";
                }

            }
        }
        string[] res = codeWithComments.Where(x => x != "").ToArray();
        return res;
    }
    private static void WriteCode(string codeFilePath, string[] codeLines)
    {
        File.WriteAllLines(codeFilePath, codeLines);
    }
}