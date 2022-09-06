Console.WriteLine("Введите длину массива");

bool isNumber = int.TryParse(Console.ReadLine(), out int number);

if(!isNumber)
{
    Console.WriteLine("Пожалуйста, введите корректное число");
    return;
}


int[] FillArray (int length)
{
    int[] array = new int[length];

    Random random = new Random();

    for(int i = 0; i < length; i++)
    {
        array[i] = random.Next(-100, 101);
    }
    return array;
}

void PrintArray (int[] array)
{
    if(array.Length <= 0)
    {
        Console.WriteLine("Длина массива не может быть отрицательным числом или равняться нулю");
        return;
    }

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] result = FillArray(number);
PrintArray(result);

int FindMax (int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

Console.WriteLine();

int max = FindMax(result);
Console.WriteLine($"Максимальный элемент массива: {max}");

int FindMin (int[] array)
{
    int min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

int min = FindMin(result);
Console.WriteLine($"Минимальный элемент массива: {min}");

int diff = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементом массива составляет {diff}");