using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;

namespace FileManager
{
    class Program
    {
        public static bool Bufer0;
        public static string Bufer1;
        public static string Path0;
        public static string[] Path;
        public static string[] Files;

        static void Main()
        {
            Диски();
            Start();
        }

        private static void Start()
        {
            try
            {
                bool asd = true;
                while(asd)
                {
                    Console.Clear();
                    int num = 0;
                    foreach (var i in Files)
                    {
                        Console.WriteLine("<" + num + "> " + i);
                        num++;
                    }
                    var input = Console.ReadLine();
                    if (uint.TryParse(input, out uint a))
                    {
                        if (a == 0)
                        {
                            try
                            {
                                Назад(Path0);
                            }
                            catch(Exception)
                            {
                                Диски();
                            }
                        }
                        else if (a > 0)
                        {
                            ПолучПутей(Path[a-1]);
                        }
                    }
                    else if(input == "E")
                    {
                        asd = false;
                    }
                    else if(input == "C")
                    {
                        Копировать();
                    }
                    else if (input == "X")
                    {
                        Вырезать();
                    }
                    else if (input == "V")
                    {
                        Вставить();
                    }
                    else if (input == "D")
                    {
                        Удалить();
                    }
                }
            }
            catch (Exception)
            {
                Start();
            }
        }
        public static void Удалить()
        {
            int.TryParse(Console.ReadLine(), out int c);
            File.Delete(Path[c - 1]);
            ПолучПутей(Path0);
        }

        public static void Вырезать()
        {
            int.TryParse(Console.ReadLine(), out int c);
            Bufer1 = Path[c - 1];
            Bufer0 = true;
        }

        public static void Вставить()
        {
            string name = Console.ReadLine();
            if(Bufer0)
            {
                File.Move(Bufer1, Path0 + "/" + name);
                ПолучПутей(Path0);
            }
            else
            {
                File.Copy(Bufer1, Path0 + "/" + name);
                ПолучПутей(Path0);
            }
        }

        public static void Копировать() 
        {
            int.TryParse(Console.ReadLine(), out int c);
            Bufer1 = Path[c - 1];
            Bufer0 = false;
        }

        private static void Чтение(string path)
        {
            Files = File.ReadAllLines(path);
        }

        private static void Назад(string path)
        {
            var a = Directory.GetParent(path).FullName;
            ПолучПутей(a);
        }

        private static void Диски()
        {

            Path = DriveInfo.GetDrives().Select(x => x.Name).ToArray();
            string[] a = { "- Назад\n<E> - Выход из программы\n<C> - Копировать\n<X> - Вырезать\n<V> - Вставить\n<D> - Удалить\n" };
            Files = a.Concat(DriveInfo.GetDrives().Select(x => x.Name)).ToArray();
        }

        private static void ПолучПутей(string path)
        {
            try
            {
                var getDir = Directory.GetDirectories(path);
                var getFile = Directory.GetFiles(path);
                Path = getDir.Concat(getFile).ToArray();
                string[] nul = { "Назад" };
                Files = nul.Concat(getDir.Concat(getFile)).ToArray();
            }
            catch (Exception)
            {
                Чтение(path);
            }
            finally
            {
                Path0 = path;
            }
        }
    }
}