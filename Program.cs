using System;

namespace GB_HW54
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Введите количетсво строк: ");
            int m = Convert.ToInt32(Console.ReadLine());

            void FillMatrix(int[,] matr)
            {
                for (int i = 0; i < matr.GetLength(0); i++)
                {
                    for (int j = 0; j < matr.GetLength(1); j++)
                    {
                        matr[i, j] = rand.Next(-100, 100);
                        Console.Write(matr[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            Console.Write("Введите количество столбцов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[m, n];
            int accum = 0;
            Console.WriteLine("Изначальный массив: ");
            FillMatrix(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int sort = 0; sort < matrix.GetLength(1) - 1; sort++)
                    {
                        if (matrix[i, sort] < matrix[i, sort + 1])
                        {
                            accum = matrix[i, sort + 1];
                            matrix[i, sort + 1] = matrix[i, sort];
                            matrix[i, sort] = accum;
                        }
                    }
                }
            }
            Console.WriteLine("Отсортированный массив: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
