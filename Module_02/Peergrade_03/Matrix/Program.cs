using System;

// Дорогой друг, надейюсь мой скромный калькулятор понравится тебе. Да, я знаю, ввод данных реализован не полностью. Очень надеюсь, что будешь оценивать не строго.
namespace Matrix
{
    class Program
    {
        // Метод задаёт размер матрице А.
        static void InPutSizeA(out int m, out int n)
        {
            Console.WriteLine("Введите количество строк матрицы A: ");
            int.TryParse(Console.ReadLine(), out m);
            Console.WriteLine("Введите количество столбцов матрицы A: ");
            int.TryParse(Console.ReadLine(), out n);
            return;
        }

        // Метод задаёт размер матрице В.
        static void InPutSizeB(out int m, out int n)
        {
            Console.WriteLine("Введите количество строк матрицы B: ");
            int.TryParse(Console.ReadLine(), out m);
            Console.WriteLine("Введите количество столбцов матрицы B: ");
            int.TryParse(Console.ReadLine(), out n);
            return;
        }

        // Метод заполняет матрицу.
        static double[,] InPut(int m, int n, string ab)
        {
            double[,] a = new double[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Clear();
                    Print(a);
                    Console.WriteLine($"Введите {j + 1}-й элемент {i + 1}-ого столбца матрицы " + ab);
                    double.TryParse(Console.ReadLine(), out a[i, j]);
                }
            }
            return a;
        }

        // Метод складывает матрицы.
        static double[,] Sum(double[,] a, double[,] b)
        {
            double[,] res = new double[a.GetLength(0), b.GetLength(1)];
            for (int m = 0; m < a.GetLength(0); m++)
            {
                for (int n = 0; n < a.GetLength(1); n++)
                {
                    res[m, n] = a[m, n] + b[m, n];
                }
            }
            return res;
        }

        // Метод транспонирует матрицу.
        static double[,] Trans(double[,] mtx)
        {
            Console.WriteLine("Trans");
            int mtxM = mtx.GetLength(0);
            int mtxN = mtx.GetLength(1);
            double[,] newMtx = new double[mtxN, mtxM];
            for (int m = 0; m < mtxM; m++)
            {
                for (int n = 0; n < mtxN; n++)
                {
                    newMtx[n, m] = mtx[m, n];
                }
            }
            return newMtx;
        }

        // Метод выводит матрицу на консоль.
        static void Print(double[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Метод умножающий матрицу на число.
        static double[,] MultiplierByNumber(double[,] mtx, double chislo)
        {
            double[,] newMtx = new double[mtx.GetLength(0), mtx.GetLength(1)];
            for (int i = 0; i < mtx.GetLength(0); i++)
            {
                for (int j = 0; j < mtx.GetLength(1); j++)
                {
                    newMtx[i, j] = mtx[i, j] * chislo;
                }
            }
            return newMtx;
        }

        // Метод умножающий две матрицы.
        static double[,] MatrixMultiplier(double[,] a, double[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            double[,] r = new double[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }

        // Метод находит след матрицы.
        static double MatrixTrace(double[,] a)
        {
            Console.WriteLine("Trace");
            int n = a.GetLength(0) >= a.GetLength(1) ? a.GetLength(0) : a.GetLength(1);
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + a[i, i];
            }
            return sum;
        }

        // Метод находит определитель квадратной матрицы.
        static double DeterminantGaussElimination(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            int nm1 = n - 1;
            int kp1;
            double p;
            double det = 1;
            for (int k = 0; k < nm1; k++)
            {
                kp1 = k + 1;
                for (int i = kp1; i < n; i++)
                {
                    p = matrix[i, k] / matrix[k, k];
                    for (int j = kp1; j < n; j++)
                        matrix[i, j] = matrix[i, j] - p * matrix[k, j];
                }
            }
            for (int i = 0; i < n; i++)
                det = det * matrix[i, i];
            return det;

        }

        // Точка входа на программу.
        static void Main(string[] args)
        {
            bool asd = true;
            while (asd)
            {
                try
                {
                    Console.WriteLine("<<Trans>> - команда возвращает транспонированную матрицу" +
                                    "\n<<Track>> - команда возвращает след матрицы" +
                                    "\n<<Det>> - команда возвращает определитель матрицы" +
                                    "\n<<k*A>> - команда умножает матрицу на число" +
                                    "\n<<A+B>> - команда возвращает сумму двух матриц" +
                                    "\n<<A-B>> - команда возвращает разность двух матриц" +
                                    "\n<<A*B>> - команда возвращает произведение двух матриц" +
                                    "\n<<Exit>> - команда завершает работу программы\n");
                    Console.WriteLine("Введите команду: ");
                    string comand = Console.ReadLine();
                    if (comand == "Trans")
                    {
                        InPutSizeA(out int m, out int n);
                        var a = InPut(m, n, "A");
                        Console.Clear();
                        Console.WriteLine("Матрица А равна:");
                        Print(a);
                        Console.WriteLine("Транспонированная матрица A равна:");
                        Print(Trans(a));
                    }
                    else if (comand == "Track")
                    {
                        InPutSizeA(out int m, out int n);
                        var a = InPut(m, n, "A");
                        Console.Clear();
                        Console.WriteLine("Матрица А равна:");
                        Print(a);
                        Console.WriteLine("След матрицы A равен:");
                        Console.WriteLine(MatrixTrace(a));
                    }
                    else if (comand == "Det")
                    {
                        bool klyuch = true;
                        int m;
                        do
                        {
                            Console.WriteLine("Введите размер квадратной матрицы А:");
                            if (int.TryParse(Console.ReadLine(), out m) && m > 0)
                            {
                                klyuch = false;
                            }
                            else
                            {
                                Console.WriteLine("Введите число, которое больше нуля!");
                            }
                        } while (klyuch);
                        var a = InPut(m, m, "A");
                        Console.Clear();
                        Console.WriteLine("Матрица А равна:");
                        Print(a);
                        Console.WriteLine("Определитель матрицы A равен:");
                        Console.WriteLine(DeterminantGaussElimination(a));
                    }
                    else if (comand == "k*A")
                    {
                        bool klyuch = true;
                        double k;
                        do
                        {
                            Console.WriteLine("Введите k:");
                            if (double.TryParse(Console.ReadLine(), out k))
                            {
                                klyuch = false;
                            }
                            else
                            {
                                Console.WriteLine("Введите любое число, не буквы!");
                            }
                        } while (klyuch);
                        InPutSizeA(out int m, out int n);
                        var a = InPut(m, n, "A");
                        Console.Clear();
                        Console.WriteLine("Произведение k и матрицы А равна:");
                        Print(MultiplierByNumber(a, k));
                    }
                    else if (comand == "A+B")
                    {
                        int m1;
                        int m2;
                        int n1;
                        int n2;
                        bool rychag = true;
                        do
                        {
                            InPutSizeA(out m1, out n1);
                            InPutSizeB(out m2, out n2);
                            if (m1 == m2 && n1 == n2)
                            {
                                rychag = false;
                            }
                            else
                            {
                                Console.WriteLine("Сумму таких матриц нельзя найти!");
                            }
                        } while (rychag);
                        var a = InPut(m1, n1, "A");
                        var b = InPut(m2, n2, "B");
                        Console.Clear();
                        Console.WriteLine("Сумма матрицы А и матрицы В равна:");
                        Print(Sum(a, b));
                    }
                    else if (comand == "A-B")
                    {
                        int m1;
                        int m2;
                        int n1;
                        int n2;
                        bool rychag = true;
                        do
                        {
                            InPutSizeA(out m1, out n1);
                            InPutSizeB(out m2, out n2);
                            if (m1 == m2 && n1 == n2)
                            {
                                rychag = false;
                            }
                            else
                            {
                                Console.WriteLine("Разность таких матриц нельзя найти!");
                            }
                        } while (rychag);
                        var a = InPut(m1, n1, "A");
                        var b = MultiplierByNumber(InPut(m2, n2, "B"), -1.0);
                        Console.Clear();
                        Console.WriteLine("Разность матрицы А и матрицы В равна:");
                        Print(Sum(a, b));
                    }
                    else if (comand == "A*B")
                    {
                        int m1;
                        int m2;
                        int n1;
                        int n2;
                        bool rychag = true;
                        do
                        {
                            InPutSizeA(out m1, out n1);
                            InPutSizeB(out m2, out n2);
                            if (n1 == m2)
                            {
                                rychag = false;
                            }
                            else
                            {
                                Console.WriteLine("Такие матрицы нельзы перемножить!");
                            }
                        } while (rychag);
                        var a = InPut(m1, n1, "A");
                        var b = InPut(m2, n2, "B");
                        Console.Clear();
                        Console.WriteLine("Произведение матрицы А и матрицы В равна:");
                        Print(MatrixMultiplier(a, b));
                    }
                    else if (comand == "Exit")
                    {
                        asd = false;
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("ВЗЛОМЩИК ХАРЭ ВЗЛАМЫВАТЬ!");
                }
            }
            Console.ReadKey();
        }
    }
}
