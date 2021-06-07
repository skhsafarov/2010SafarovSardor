using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            for (int i = 100000; i < 1000000; i++)
            {
                list.Add(i.ToString());
            }
            File.WriteAllLines(@"C:\Users\sardo\Desktop\Новый текстовый документ.txt", list);
        }
    }
}
