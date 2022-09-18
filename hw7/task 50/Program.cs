// Напишите программу, которая на вход принимает число и ищет в двумерном массиве, 
// и возвращает индексы этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите количество строк");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("Введите количество столбцов");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (!isNumberM || m <= 0 || !isNumberN || n <= 0)
{
    Console.WriteLine("Одно или оба числа введены неверно");
    return;
}


Console.WriteLine("Введите число, которое хотите найти в массиве");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);

if (!isNumber)
{
    Console.WriteLine("Число введено неверно");
    return;
}

int[,] result = FillArray(m, n);
PrintArray(result);

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-10, 11);
        }
    }
    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] FindNumber (int[,] array, int number)
{
    int[] arr = new int[2];

     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == number)
            {
                arr[0] = i;
                arr[1] = j;
            }
            else
            {
                arr[0] = -100;
                arr[1] = 100;
            }
        }
    }
    return arr;
}

void PrintResult (int[] arr)
{
    if(arr[0] == -100 || arr[1] == 100)
    {
        Console.WriteLine($"Элемента {number} в массиве нет");
        return;
    }
    else
    {
        Console.Write($"({arr[0]}; {arr[1]})");
    }
}


int[] newResult = FindNumber(result, number);
PrintResult(newResult);


