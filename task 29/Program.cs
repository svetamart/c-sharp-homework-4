// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("Введите 8 значений, которыми вы хотите заполнить массив");
int[] array = new int[8];

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
