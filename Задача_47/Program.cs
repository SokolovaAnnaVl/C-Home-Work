// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.


double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(minValue + new Random().NextDouble() * (maxValue - minValue), 2);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.Write("Введите количество строк row = ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов col = ");
int col = int.Parse(Console.ReadLine()!);

double[,] array2d = GetArray(row, col, -9.9, 10.9);
PrintArray(array2d);
Console.WriteLine();