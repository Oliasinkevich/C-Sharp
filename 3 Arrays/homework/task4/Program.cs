// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

Console.WriteLine("Введите число в диапазоне от 1 до 100 000: ");
int number = Convert.ToInt32(Console.ReadLine());

int numLength = 0;
int tempNumber = number;

while (tempNumber > 0)
{
    tempNumber /= 10;
    numLength++;
}
Console.Write(numLength);

int[] array = new int[numLength];
tempNumber = number;

for (int i = 0; i < numLength; i++)
{
    array[i] = tempNumber % 10;
    tempNumber /= 10;
}
Console.WriteLine();
Array.Sort(array);

foreach (int item in array)
{
    Console.Write(item + " ");
}