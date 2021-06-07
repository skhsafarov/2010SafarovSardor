using System;

namespace VegetableWarehouse
{
    class Program
    {
        // Меин.
        static void Main()
        {
            // Объект класса рендум.
            Random random = new Random();
            // Команды
            string[] comands = { "AddCont", "DelCont", "AddBox", "CloseCont", "Exit", "Print" };
            // Объект класса - склад.
            var sklad = new Warehouse();
            int a;
            int b;
            try
            {
                Console.WriteLine("Введите вместимость склада:");
                // Проверка на корректность.
                while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    Console.WriteLine("Введите целое число больше нуля!");
                }
                Console.WriteLine("Введите цену хранения склада:");
                // Проверка на корректность.
                while (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    Console.WriteLine("Введите целое число больше нуля!");
                }
                sklad.MaxCount = a;
                sklad.Price = b;
                // Процесс добавления и удаления контейнеров со склада.
                while (true)
                {
                    // Вывод возможных команд.
                    Console.WriteLine("Введите команду " +
                        "\n{AddCont} - Поместить новый контейнер в склад" +
                        "\n{DelCont} - Удалить контейнер из склада" +
                        "\n{Print} - Вывод содержимого на экран" +
                        "\n{Exit} - Выход из программы");
                    string comand1 = Console.ReadLine();
                    if (comand1 == comands[0])
                    {
                        Container newCont = new Container();
                        // Присвоение ID.
                        newCont.Id = sklad.GetListContainers.Count + 1;
                        // Уровень повреждения, случайная величина.
                        newCont.Damage = random.Next(0, 5) / 10.0;
                        // Грузовмещаемость контейнера, случайная величина.
                        newCont.MaxWeight = random.Next(50, 1001);
                        // Процесс добавления ящиков в контейнер.
                        while (true)
                        {
                            // Вывод возможных команд.
                            Console.WriteLine("Введите команду: " +
                                "\n{AddBox} - Поместить новый ящик в контейнер" +
                                "\n{CloseCont} - Закрыть контейнер и поместить в склад");
                            string comand2 = Console.ReadLine();
                            if (comand2 == comands[2])
                            {
                                Console.WriteLine($"\nМаксимальная суммарная масса {newCont.MaxWeight}" +
                                                  $"\nСтепень повреждения {newCont.Damage}");
                                var newBox = new Box();
                                double c;
                                double d;
                                Console.WriteLine("Введите массу:");
                                while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                                {
                                    Console.WriteLine("Введите число больше нуля!");
                                }
                                newBox.Weight = c * (1 - newCont.Damage);
                                Console.WriteLine("Введиту стоимость за 1 кг:");
                                while (!double.TryParse(Console.ReadLine(), out d) || d <= 0)
                                {
                                    Console.WriteLine("Введите число больше нуля!");
                                }
                                newBox.PricePerKg = d;
                                if (newCont.SumWeight + newBox.Weight < newCont.MaxWeight)
                                {
                                    newCont.SumWeight += newBox.Weight;
                                    newCont.Price += newBox.Weight * newBox.PricePerKg;
                                    newCont.AddBox(newBox);
                                }
                                else { Console.WriteLine("Этот ящик не поместился в контейнер!"); }
                            }
                            else if (comand2 == comands[3]) { break; }
                            else { Console.WriteLine("Такой команды не существует!"); }
                        }
                        // Добавление контейнера с проверкой.
                        if (newCont.Price > sklad.Price)
                        {
                            sklad.AddCont(newCont);
                        }
                        else if (sklad.GetListContainers.Count == sklad.MaxCount)
                        {
                            sklad.DelCont(sklad.GetListContainers.Count - 1);
                            sklad.AddCont(newCont);
                        }
                        else { Console.WriteLine("Cтоимость содержимого контейнера не превосходит стоимость хранения!"); }
                    }
                    // Удаление контейнера.
                    else if (comand1 == comands[1])
                    {
                        int f;
                        Console.WriteLine("Введите ID контейнера который нужно удалить.");
                        while (!int.TryParse(Console.ReadLine(), out f) || f <= 0)
                        {
                            Console.WriteLine("Введите целое число больше нуля!");
                        }
                        sklad.DelCont(f);
                    }
                    // Выход из программы.
                    else if (comand1 == comands[4]) { break; }
                    // Вывод содержимого склада на экран.
                    else if (comand1 == comands[5]) { Console.WriteLine(sklad); }
                    else { Console.WriteLine("Такой команды не существует!"); }
                }
            }
            catch
            {
                Console.WriteLine("ИЗВИНИТЕ ЗА НЕДОСТАТКИ, ПОПРОБУЙТЕ ЗАНОВО!");
                Main();
            }
        }
    }
}
