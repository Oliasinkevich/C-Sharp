// Задайте одномерный массив, заполненный случайными числами. Определите количество простых чисел в этом массиве.

// Примеры

// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

int WorkWithUser(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[] GetNewArray(int len, int minValue, int maxValue)
{
    int[] newArray = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        newArray[i] = rnd.Next(minValue, maxValue);
    }
    return newArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int GetCountNormalNumber(int[] array)
{
    int counter = 0;
    bool isPrime = false;
    for (int i = 0; i < array.Length; i++)
    {
        isPrime = true;
        for (int j = 2; j < array[i]; j++)
        {
            if (array[i] % j == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            counter++;
        }
    }
    return counter;
}

int size = WorkWithUser("Введите размер массива: ");
int min = WorkWithUser("Введите минимальное значение диапазона: ");
int max = WorkWithUser("Введите максимальное значение диапазона: ");
int[] array2 = GetNewArray(size, min, max);
PrintArray(array2);
System.Console.WriteLine(GetCountNormalNumber(array2));
