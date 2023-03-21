// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void SumNatural(int M, int N)
{
    Console.Write(SumMN(M - 1, N));
}

int SumMN(int M, int N)
{
    int result = M;
    if (M == N)
        return 0;
    else
    {
        M++;
        result = M + SumMN(M, N);
        return result;
    }
}

Console.Clear();

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write($"Сумма натуральных элементов в промежутке от M до N = {SumMN(M, N) + M}");
Console.WriteLine();
