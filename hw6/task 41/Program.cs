// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите длину массива");

bool isNumber = int.TryParse(Console.ReadLine(), out int number);

if(!isNumber)
{
    Console.WriteLine("Пожалуйста, введите корректное число");
    return;
}

int[] array = new int[number];
if(array.Length <= 0)
    {
        Console.WriteLine("Длина массива не может быть отрицательным числом или равняться нулю");
        return;
    }

Console.WriteLine("Введите значения, которыми вы хотите заполнить массив");


for (int i = 0; i < array.Length; i++)
array[i] = int.Parse(Console.ReadLine());

void PrintArray (int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} "); 
    }
}

PrintArray(array);


int FindPositiveNumbers (int[] arr)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine();

int outcome = FindPositiveNumbers(array);
Console.WriteLine($"В массиве {outcome} чисел/числа больше 0");
