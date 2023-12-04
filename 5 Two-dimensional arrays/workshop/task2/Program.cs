// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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
void ChangedArray(int[,] arr) // Обход элементов для суммы элементов, находящихся на главной диагонали
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                count+=arr[i, j];
            }
        }
    }
    Console.WriteLine(count);
}

int[,] newArray = GetArray(3, 3, 5, 10);
PrintArray(newArray);
ChangedArray(newArray);