// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

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

int[] array = GetArray(5, 100, 1000);
Console.WriteLine(String.Join(", ", array));

int NewArray(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
      result += array[i];
    }
    return result;
}
int result = NewArray(array);
Console.WriteLine($"сумма элементов,\n стоящих на нечётных позициях равна: {result}");

