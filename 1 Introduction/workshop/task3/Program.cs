// Напишите программу, которая принимает на вход трёхзначное целое число и на выходе показывает сумму первой и последней цифры этого числа.
// 456  =>  10
// 782  =>  9
// 918  =>  17

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int last = number % 10;
    int first = number / 100;
    int sum = first + last;
    Console.WriteLine("Сумма первой и последней цифры этого чисела: " + sum);
}
else
{
    Console.WriteLine("Число не трехзначное");
}

