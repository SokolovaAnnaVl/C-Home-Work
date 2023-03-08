// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом 
// столбце.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
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

string GetAverageNum(int[,] inArray)
{
    string result = "Среднее арифметическое каждого столбца массива: ";
    double sum;
    double average;

    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i, j];
        }
        average = sum / inArray.GetLength(0);
        result += $"{average:f1}";
        if (j != inArray.GetLength(1) - 1) result += "; ";
        else result += ", ";
    }
    return result;
}

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива: ");
int row = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов двумерного массива: ");
int col = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] inArray = GetArray(row, col, -10, 11);
PrintArray(inArray);
Console.WriteLine(GetAverageNum(inArray));
Console.WriteLine();