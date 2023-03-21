// Задача 68: Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();

int Akkerman(int M, int N)
{
if (M == 0) return N + 1;
else if (N == 0) return Akkerman(M - 1, 1);
else return Akkerman(M - 1, Akkerman(M, N - 1));
}

Console.WriteLine("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write($"Функция Аккермана (рекурсия) = {Akkerman(M, N)}");
Console.WriteLine();