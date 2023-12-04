// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int GetSumOfRow(int[,] arr, int row)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum += arr[row, j];
    }
    return sum;
}

int FindRow(int[,] arr)
{
    int smallestSum = Int32.MaxValue;
    int smallestRow = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int sum = GetSumOfRow(arr, i);
            if (sum < smallestSum)
            {
                smallestSum = sum;
                smallestRow = i;
            }
        }
    }
    return smallestRow;
}

int[,] newArray = GetArray(2, 6, 5, 10);
PrintArray(newArray);
Console.WriteLine();

int rowWithSmallestSum = FindRow(newArray);
Console.WriteLine($"Строка с наименьшей суммой элементов: {rowWithSmallestSum}");
