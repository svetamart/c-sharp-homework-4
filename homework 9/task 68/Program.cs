// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Введите неотрицательное число M");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("Введите неотрицательное число N");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (!isNumberN || !isNumberM || m < 0 || n < 0)
{
    Console.WriteLine("Одно или оба числа введены неверно");
    return;
}

Console.Write($"A({m}, {n}) = {Ackermann(m, n)}");

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
    return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}
