// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

double [] array = new double [4];
double minDigit = double.MaxValue;
double maxDigit = double.MinValue;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() * 100;
    Console.Write(array[i] + ", ");
}
Console.WriteLine();
foreach (double item in array)
{
    if (item < minDigit)
    {
        minDigit = item;
    }
    if (item > maxDigit)
    {
        maxDigit = item;
    }
}

double difference = maxDigit - minDigit;
Console.Write(minDigit);
Console.WriteLine();
Console.Write(maxDigit);
Console.WriteLine();
Console.WriteLine(difference);