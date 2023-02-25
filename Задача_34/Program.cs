// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int CountElements(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = GetArray(7, 100, 1000);
Console.WriteLine(String.Join(", ", array));

int N = CountElements(array);
Console.WriteLine($"Количество четных чисел в массиве: {N}");