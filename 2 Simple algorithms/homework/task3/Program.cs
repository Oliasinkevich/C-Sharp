// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Write("Введите число от 10 до 99: ");
int number = Convert.ToInt32(System.Console.ReadLine());

int firsthDigit = 0;
int secondDigit = 0;

if (number >= 10 && number <= 99)
{
firsthDigit = number / 10; // 25 / 10 = 2
secondDigit = number % 10; // (25 )% 10 = 5
    if (firsthDigit >= secondDigit)
    {
        Console.WriteLine(firsthDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}
else
{
Console.WriteLine("Вы ввели число не в промежутке от 10 до 99");
}
