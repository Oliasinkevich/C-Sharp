// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] GetArray(int m, int n, int min, int max) // Обход в заполнении рандомных чисел
{
    int[,] array = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(min, max);
        }
    }
    return array;
}

void PrintArray(int[,] arr) // Обход элементов двумерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int GetElement(int[,] arr, int x, int y)
{
    if (x >= 0 && x < arr.GetLength(0) && y >= 0 && y < arr.GetLength(1))
    {
        return arr[x, y];
    }
    else
    {
        return -1; // или можно просто вернуть 0 или другое значение по умолчанию
    }
}
void ChangedArray(int[,] arr) 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int element = GetElement(arr, i, j);
            if (element != null)
            {
                Console.WriteLine($"Значение элемента: строка - {i}, столбец - {j}: {element}");
            } 
            else
            {
                Console.WriteLine($"Элемента в строке {i}, столбце {j} нет");
            }
        }
    }
}

int[,] newArray = GetArray(3, 3, 5, 10);
PrintArray(newArray);
ChangedArray(newArray);