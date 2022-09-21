// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("Введите число N");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (!isNumberN || !isNumberM || m > n)
{
    Console.WriteLine("Одно или оба числа введены неверно. Число М должно быть меньше или равно числу N");
    return;
}

Console.WriteLine($"Сумма чисел от {m} до {n} равна {FindSum(m, n)}");

int FindSum (int m, int n)
{
    int sum = m;
    if(m >= n)
    {
        return sum;
    }
    else
    {
        return m + FindSum(m + 1, n);
    }
}
