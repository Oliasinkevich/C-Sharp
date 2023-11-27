// Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.

// Примеры

// a = 256 => 26
// a = 891 => 81

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int firsthDigit = 0;
int thirdDigit = 0;

if (number >= 100 && number <= 999)
{
firsthDigit = number / 100; // 256 / 100 = 2
thirdDigit = number % 10; // (256 )% 10 = 6
Console.WriteLine(firsthDigit * 10 + thirdDigit);
}
else if (number < 0)
{
Console.WriteLine("Вы ввели отрицательное число");
}
else if (number >= 1000)
{
Console.WriteLine("Вы ввели более трех знаков число");
}
else
{
Console.WriteLine("Вы ввели менее трех знаков число");
}