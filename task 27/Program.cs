// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
bool CheckNumber = int.TryParse(Console.ReadLine(), out int number);

if(!CheckNumber)
{
    Console.WriteLine("Число введено неверно");
    return;
}

int GetDigitSum (int n)
{
    int sum = 0;
    int n1 = n;

    while(n1 > 0)
    {
        sum = sum + n1 % 10;
        n1 = n1 / 10;
    }
    return sum;
}

int digitSum = GetDigitSum(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {digitSum}");

