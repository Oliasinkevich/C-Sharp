// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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
void ChangedArray(int[,] arr) // Обход элементов, где индексы чётные и замена этих элементов на их квадраты
{
    for (int i = 0; i < arr.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < arr.GetLength(1); j = j + 2)
        {
            arr[i, j] = arr[i, j] * arr[i, j];
        }
    }
}

int[,] newArray = GetArray(3, 3, 5, 10);
PrintArray(newArray);
ChangedArray(newArray);
Console.WriteLine();
PrintArray(newArray);





