// Напишите программу, которая принимает на вход трёхзначное число и возводит вторую цифру этого числа в степень, равную третьей цифре.

// Примеры

// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = 0;
int thirdDigit = 0;
int result = 1;

if (number >= 100 && number <= 999)
{
secondDigit = number % 100 / 10; // (256) % 100 / 10 = 5
thirdDigit = number % 10; // (256) % 10 = 6
    for (int i = 0; i < thirdDigit; i++)
    {
        result*=secondDigit;
    }
Console.WriteLine(result);
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