// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("Введите количество столбцов");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (!isNumberM || m <= 0 || !isNumberN || n <= 0)
{
    Console.WriteLine("Одно или оба числа введены неверно");
    return;
}

int[,] result = FillArray(m, n);
PrintArray(result);
Console.WriteLine();

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 11);
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

double[] FindColumnSum(int[,] array, int m, int n)
{
    double[] sum = new double[n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            sum[i] = sum[i] + array[j, i];
        }
    }
    return sum;
}


double[] columnSum = FindColumnSum(result, m, n);
double[] average = FindAverageMean(columnSum, m);
PrintAverage(average);


void PrintAverage(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }     
}

double[] FindAverageMean (double[] array, int m)
{
    double[] average = new double[array.Length];
    for (int i = 0; i < average.Length; i++)
    {
        average[i] = array[i] / m;
    }
    return average;
}