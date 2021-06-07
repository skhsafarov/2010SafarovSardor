using System;
using System.IO;
using System.Linq;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "13156";
            File.WriteAllText("IntNumber.txt", a);
        }
    }
}
