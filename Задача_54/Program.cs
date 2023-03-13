// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GetArray(int rows, int col, int minValue, int maxValue)
{
    int[,] Array = new int[rows, col];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return Array;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1) - 1; j++)
        {
            for (int A = i + j; A < Array.GetLength(1); A++)
            {
                if (Array[i, j] < Array[i, A])
                {
                    int temp = Array[i, j];
                    Array[i, j] = Array[i, A];
                    Array[i, A] = temp;
                }
            }

        }
    }
}

Console.Clear();

Console.WriteLine("Введите rows: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите col: ");
int col = int.Parse(Console.ReadLine()!);

int[,] NewArray = GetArray(rows, col, -10, 10);
Console.WriteLine();
PrintArray(NewArray);
SortArray(NewArray);
Console.WriteLine();
PrintArray(NewArray);