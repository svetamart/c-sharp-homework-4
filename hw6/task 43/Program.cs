// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Определите точку k1 для первой прямой");
bool CheckNumberK1 = double.TryParse(Console.ReadLine(), out double k1);

Console.WriteLine("Определите точку b1 для первой прямой");
bool CheckNumberB1 = double.TryParse(Console.ReadLine(), out double b1);

Console.WriteLine("Определите точку k2 для второй прямой");
bool CheckNumberK2 = double.TryParse(Console.ReadLine(), out double k2);

Console.WriteLine("Определите точку b2 для второй прямой");
bool CheckNumberB2 = double.TryParse(Console.ReadLine(), out double b2);

if(!CheckNumberK1 || !CheckNumberB1 || !CheckNumberK2 || !CheckNumberB2)
{
    Console.WriteLine("Одно или несколько чисел введены неверно");
    return;
}


bool CheckIfParallel (double k1, double k2, double b1, double b2)
{
    if(k1 == k2)
    {
        return false;
    }
    else
    {
        return true;
    }
}

if(CheckIfParallel(k1, k2, b1, b2) == false)
{
    Console.WriteLine("Прямые параллельны и не могут пересекаться");
    return;
}
else
{
    PrintArray(FindPointOfIntersection(k1, k2, b1, b2));
}


void PrintArray (string[] arr)
{
    Console.Write($"({arr[0]}; {arr[1]})");
}

string[] FindPointOfIntersection (double k1, double k2, double b1, double b2)
{
    string[] arr = new string[2];
    double x;
    double y;
    x = (b2 - b1) / (k1 - k2);
    y = k2 * x + b2;
    arr[0] = Convert.ToString(x);
    arr[1] = Convert.ToString(y);
    return arr;
}
