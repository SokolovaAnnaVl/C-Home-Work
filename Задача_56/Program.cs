// Задача 56: Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой элементов.

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

void GetMinSum(int[,]inArray)
{
    int min = -100;
    int minrow = 1;
    int sum;
    bool isStarted = false;

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
        }

        if (!isStarted || sum < min)
        {
            isStarted = true;
            min = sum;
            minrow = i + 1;
        }
    }
    Console.WriteLine($"{minrow} строка");
}

Console.Clear();

Console.WriteLine("Введите rows: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите col: ");
int col = int.Parse(Console.ReadLine()!);

int[,] NewArray = GetArray(rows, col, -10, 10);
Console.WriteLine();
PrintArray(NewArray);
GetMinSum(NewArray);
Console.WriteLine();
