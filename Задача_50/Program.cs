// Задача 50: Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.

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

string GetElemArray(int n, int m, int[,] inArray)
{
    if (n < 0 || m < 0) return "Ошибка, Числа должны быть положительными";
    string result;
    bool GetElem = n <= inArray.GetLength(0) && m <= inArray.GetLength(1);
    if (GetElem)
    {
        result = $"{n}, {m} -> {inArray[n, m]}";
    }
    else
    {
        result = $"{n}, {m} -> данная позиция отсутствует в массиве";
    }
    return result;
}

Console.Clear();

int row = new Random().Next(4, 5);
int col = new Random().Next(4, 5);
int[,] NewArray = GetArray(row, col, -10, 10);
PrintArray(NewArray);
Console.WriteLine();

Console.WriteLine("Введите номер позиции элемента через пробел: ");
int[] posit = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
int n = posit[0], m = posit[1];
Console.WriteLine(GetElemArray(n, m, NewArray));
Console.WriteLine();


