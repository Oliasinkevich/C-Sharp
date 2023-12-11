// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int[] array = {1, 2, 5, 0, 10, 34};

PrintReversedArray(array, array.Length - 1);

void PrintReversedArray(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write(array[index] + " "); 
        PrintReversedArray(array, index - 1); 
    }
}

