// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите параметры массива");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
bool isNumberL = int.TryParse(Console.ReadLine(), out int l);



if (!isNumberM || m <= 0 || !isNumberN || n <= 0 || !isNumberL || l <= 0)
{
    Console.WriteLine("Одно или несколько чисел введены неверно");
    return;
}



int[] arr = FillArray(m, n, l);
int[,,] result = Fill3DArray(arr, m, n, l);
Console.WriteLine();
ShowArrayElements(result);



int[] FillArray(int m, int n, int l)
{
    int[] tempArray = new int[m * n * l];
    int number;
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        tempArray[i] = new Random().Next(10, 100);
        number = tempArray[i];
        if (i > 0)
        {
            for (int j = 0; j < i; j++)
            {
                if (tempArray[i] == tempArray[j])
                {
                    tempArray[i] = new Random().Next(10, 100);
                    j--;
                }
                number = tempArray[i];
            }
        }
    }
    return tempArray;
}


int[,,] Fill3DArray(int[] array, int m, int n, int l) 
{
    int[,,] newArray = new int[m, n, l];
    int x = 0;
    {
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                for (int k = 0; k < newArray.GetLength(2); k++)
                {
                    newArray[i, j, k] = array[x];
                    x++;
                }
            }
        }
    }
    return newArray;
}


void ShowArrayElements(int[,,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}





