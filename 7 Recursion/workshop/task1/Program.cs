// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// Указание
// Использовать рекурсию.

// Пример
// 123 => 6
// 63 => 9

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int GetSumRecurs(int num)
{
    if (num == 0) return 0;
    return num % 10 + GetSumRecurs(num / 10);
}

Console.WriteLine(GetSumRecurs(number));