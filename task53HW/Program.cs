// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

internal class Program
{
    private static void Main(string[] args)
    {
        void FillMatrixWithRandom(int[,] matrix)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                }
            }
        }

        void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }


        Console.WriteLine("Введите кол-во строк: ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов: ");
        int column = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[row, column];
        FillMatrixWithRandom(matrix);
        PrintMatrix(matrix);

        double sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = sum + matrix[i, j];
            }
            sum = sum / row;
            Console.WriteLine(string.Format("Среднеарефметическое  {0} столбца {1}", j, sum));
            sum = 0;
        }
    }
}