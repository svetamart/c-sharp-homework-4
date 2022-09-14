Console.WriteLine("Введите количество строк");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("Введите количество столбцов");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (!isNumberM || m <= 0 || !isNumberN || n <= 0)
{
    Console.WriteLine("Одно или оба числа введены неверно");
    return;
}

double[,] result = FillArray(m, n);
PrintArray(result);

double[,] FillArray(int m, int n)
{
    double[,] array = new double[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(random.Next(0, 100) / 10.0);
        }
    }
    return array;
}


void PrintArray(double[,] array)
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
