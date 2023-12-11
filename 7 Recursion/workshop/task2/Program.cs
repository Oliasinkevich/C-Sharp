// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// Указание
// Использовать рекурсию. Не использовать цикл.

// Пример

// N=5 => 1 2 3 4 5

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int start = 1;
void GetNumbers(int start, int num)
{
    if (start <= num)
    {
        Console.Write(start + " ");
        GetNumbers(start + 1, num);
    }
}
GetNumbers(start, number);
