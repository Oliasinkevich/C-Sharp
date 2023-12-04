// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца

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
int[,] RemovedRow(int[,] arr)
{
    // Находим минимальный элемент и его индексы
    int minEl = arr[0, 0];
    int minRow = 0;
    int minCol = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < minEl)
            {
                minEl = arr[i, j];
                minRow = i;
                minCol = j;
            }
        }
    }

    Console.WriteLine(minEl);
    Console.WriteLine();

    int newRows = arr.GetLength(0) - 1;
    int newCols = arr.GetLength(1) - 1;
    int[,] newArr = new int[newRows, newCols];

    int newRow = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        // Пропускаем минимальную строку
        if (i == minRow)
            continue;

        int newCol = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // Пропускаем минимальный столбец
            if (j == minCol)
                continue;

            newArr[newRow, newCol] = arr[i, j];
            newCol++;
        }
        newRow++;
    }

    return newArr;
}

int[,] newArray = GetArray(5, 5, 5, 10);
PrintArray(newArray);
Console.WriteLine();

int[,] modifiedArray = RemovedRow(newArray);
PrintArray(modifiedArray);
