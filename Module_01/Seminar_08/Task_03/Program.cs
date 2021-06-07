using System;
using System.IO;
using System.Linq;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {

            FileInfo[] a = new DirectoryInfo("G:/Сардор").GetFiles();

            foreach (var i in a)
                Console.WriteLine(i.Name);
        }
    }
}
