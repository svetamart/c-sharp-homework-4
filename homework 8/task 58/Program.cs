// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк массивов");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("Введите количество столбцов массивов");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (!isNumberM || m <= 0 || !isNumberN || n <= 0)
{
    Console.WriteLine("Одно или оба числа введены неверно");
    return;
}



int[,] firstArray = FillArray(m, n);
int[,] secondArray = FillArray(m, n);
Console.WriteLine("Первая матрица: ");
Print2DArray(firstArray);
Console.WriteLine("Вторая матрица: ");
Print2DArray(secondArray);
Console.WriteLine("Произведение матриц: ");
int[,] multipliedArray = MultiplyArrays(firstArray, secondArray, m, n);
Print2DArray(multipliedArray);



int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}


void Print2DArray(int[,] array)
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


int[,] MultiplyArrays (int[,] array1, int[,] array2, int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
                    {
                        result[i, j] += array1[i, k] * array2[k, j];
                    }
        }
    }
    return result;
}
