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

int FindOddPositionElementsSum (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

Console.WriteLine();

int outcome = FindOddPositionElementsSum(result);
Console.WriteLine(outcome);