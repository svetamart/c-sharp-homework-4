// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


Console.WriteLine("Введите число M");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("Введите число N");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (!isNumberN || !isNumberM || m > n)
{
    Console.WriteLine("Одно или оба числа введены неверно. Число М должно быть меньше или равно числу N");
    return;
}

int[] list = new int[n - m + 1];
int[] result = ListNumbers(list, m, n);
Console.Write($"Натуральные числа от {m} до {n}: ");
PrintArray(result);

int[] ListNumbers(int[] array, int m, int n, int i = 0)
{
    array[i] = m;
    if (m >= n)
    {
        return array;
    }
    else
    {
        return ListNumbers(array, m + 1, n, i + 1);
    }

}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}





// void ListNumbers(int m, int n)
// {
//     if(m > n)
//     {
//         return;
//     }
//     Console.Write($"{m} ");
//     ListNaturalNumbers(m + 1, n);

// }