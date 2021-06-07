using System;
using System.IO;
using System.Linq;
using System.Text;

namespace FileManager
{
    class Program
    {
        public static string Sep = Path.DirectorySeparatorChar.ToString();
        public static bool Bufer0;
        public static string Bufer1;
        public static string Path0;
        public static string[] Path1;
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
                while (asd)
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
                            catch (Exception)
                            {
                                Диски();
                            }
                        }
                        else if (a > 0)
                        {
                            ПолучПутей(Path1[a - 1]);
                        }
                    }
                    else if (input == "E")
                    {
                        asd = false;
                    }
                    else if (input == "C")
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
                    else if (input == "Cr")
                    {
                        Создать();
                    }
                }
            }
            catch (Exception)
            {
                Start();
            }
        }

        public static void Создать()
        {
            string name = Console.ReadLine();
            if (!Files.Contains(name))
            {
                Encoding a = Encoding.UTF8;
                bool asd = true;
                while (asd)
                {
                    Console.Clear();
                    Console.WriteLine("1. UTF8");
                    Console.WriteLine("2. UTF7");
                    Console.WriteLine("3. UTF32");
                    int.TryParse(Console.ReadLine(), out int b);
                    if (b == 1)
                    {
                        a = Encoding.UTF8;
                        asd = false;
                    }
                    else if (b == 2)
                    {
                        a = Encoding.UTF7;
                        asd = false;
                    }
                    else if (b == 3)
                    {
                        a = Encoding.UTF32;
                        asd = false;
                    }
                }
                File.WriteAllText(Path0 + Sep + name, null, a);
            }
            ПолучПутей(Path0);
        }

        public static void Удалить()
        {
            int.TryParse(Console.ReadLine(), out int c);
            File.Delete(Path1[c - 1]);
            ПолучПутей(Path0);
        }

        public static void Вырезать()
        {
            int.TryParse(Console.ReadLine(), out int c);
            Bufer1 = Path1[c - 1];
            Bufer0 = true;
        }

        public static void Вставить()
        {
            string name = Console.ReadLine();
            if (Bufer0)
            {
                File.Move(Bufer1, Path0 + Sep + name);
                ПолучПутей(Path0);
            }
            else
            {
                File.Copy(Bufer1, Path0 + Sep + name);
                ПолучПутей(Path0);
            }
        }

        public static void Копировать()
        {
            int.TryParse(Console.ReadLine(), out int c);
            Bufer1 = Path1[c - 1];
            Bufer0 = false;
        }

        private static void Чтение(string path)
        {
            Encoding a = Encoding.UTF8;
            bool asd = true;
            while (asd)
            {
                Console.Clear();
                Console.WriteLine("1. UTF8");
                Console.WriteLine("2. UTF7");
                Console.WriteLine("3. UTF32");
                int.TryParse(Console.ReadLine(), out int b);
                if(b==1)
                {
                    a = Encoding.UTF8;
                    asd = false;
                }
                else if (b == 2)
                {
                    a = Encoding.UTF7;
                    asd = false;
                }
                else if (b == 3)
                {
                    a = Encoding.UTF32;
                    asd = false;
                }
            }
            
            string[] nul = { "Назад" };
            Files = nul.Concat(File.ReadAllLines(path, a)).ToArray();
        }

        private static void Назад(string path)
        {
            var a = Directory.GetParent(path).FullName;
            ПолучПутей(a);
        }

        private static void Диски()
        {

            Path1 = DriveInfo.GetDrives().Select(x => x.Name).ToArray();
            string[] a = { "- Назад (Введите чтобы вернуться назад)\n" +
                    "<E> - Выход (Введите чтобы выйти из программы)\n" +
                    "<C> - Копировать (Введите команду затем номер файла)\n" +
                    "<X> - Вырезать (Введите команду затем номер файла)\n" +
                    "<V> - Вставить (Введите команду затем новое имя файла)\n" +
                    "<D> - Удалить (Введите команду затем номер файла)\n" +
                    "<Cr> - Создать (Введите команду затем имя файла)\n" };
            Files = a.Concat(DriveInfo.GetDrives().Select(x => x.Name)).ToArray();
        }

        private static void ПолучПутей(string path)
        {
            try
            {
                var a = Directory.GetDirectories(path);
                var b = Directory.GetFiles(path);
                Path1 = a.Concat(b).ToArray();
                string[] nul = { "Назад" };
                var a1 = new DirectoryInfo(path).GetDirectories();
                var b1 = new DirectoryInfo(path).GetFiles();
                var a2 = a1.Select(x => x.Name).ToArray();
                var b2 = b1.Select(x => x.Name).ToArray();
                Files = nul.Concat((a2.Concat(b2)).ToArray()).ToArray();
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