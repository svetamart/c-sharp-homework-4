Console.WriteLine("Введите число А");
bool CheckNumberA = int.TryParse(Console.ReadLine(), out int numberA);

Console.WriteLine("Введите число B");
bool CheckNumberB = int.TryParse(Console.ReadLine(), out int numberB);

if(!CheckNumberA || !CheckNumberB)
{
    Console.WriteLine("Одно или оба числа введены неверно");
    return;
}

int GetExponents (int n1, int n2)
{
    if(n2 <= 0)
    {
    return 0;
    }

    int result = n1;
    for (int count = 2; count <= n2; count++)
    {
        result = result * n1;
    }
    return result;
}

int exponent = GetExponents(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно {exponent}");
