// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int [] array = new int[10];
int quantity = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
foreach (int item in array)
{
    if (item % 2 == 0)
    {
        Console.Write(item + " ");
        quantity++;
    }   
}
Console.WriteLine();
Console.WriteLine(quantity);