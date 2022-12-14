// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n = 4;
int m = 4;


int[,] squareArray = Fill2DArray(m, n);
Print2DArray(squareArray);


int[,] Fill2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    int i = 0;
    int j = 0;
    int number = 1;
    while (j < n - 1)
    {
        result[i, j] = number;
        j++;
        number++;
    }
    while (i < n - 1)
    {
        result[i, n - 1] = number;
        i++;
        number++;
    }
    j = n - 1;
    while (j >= 0)
    {
        result[m - 1, j] = number;
        j--;
        number++;
    }
    j = 0;
    for (i = m - 2; i > 0; i--)
    {
        result[i, j] = number;
        number++;
    }
    j++;
    while (j <= n - 2)
    {
        result[i + 1, j] = number;
        j++;
        number++;
    }
    j = n - 2;
    i = m - 2;

    while (j > 0)
    {
        result[i, j] = number;
        j--;
        number++;
    }
    return result;
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