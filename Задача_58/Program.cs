// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.

int[,] GetMatrix(int n, int m, int minValue, int maxValue)
{
    int[,] matrix = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Умножение элементов матрицы невозможно!");
        return matrix3;
    }
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            for (int c = 0; c < matrix3.GetLength(1); c++)
            {
                matrix3[i, j] += matrix1[i, c] * matrix2[c, j];
            }
        }
    }
    return matrix3;
} 

Console.Clear();

Console.WriteLine("Введите размерность Матрицы1 через запятую: ");
int[] dimension1 = Array.ConvertAll(Console.ReadLine().Split(','), Convert.ToInt32);
int[,] matrix1 = GetMatrix(dimension1[0], dimension1[1], -10, 10);

Console.WriteLine("Введите размерность Матрицы2 через запятую: ");
int[] dimension2 = Array.ConvertAll(Console.ReadLine().Split(','), Convert.ToInt32);
int[,] matrix2 = GetMatrix(dimension2[0], dimension2[1], -10, 10);
Console.WriteLine();

PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
int[,] matrix3 = MultMatrix(matrix1, matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц: ");
PrintMatrix(matrix3);