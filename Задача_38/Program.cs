// Задача 38: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным 
// элементов массива.

Console.Clear();

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }

    return result;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double[] array = GetArray(5, 1, 100);
Console.WriteLine(String.Join(", ", array));

double Raznica = FindMax(array) - FindMin(array);
Console.WriteLine($"Разница между Max и Min элементами массива равна: {Raznica}");