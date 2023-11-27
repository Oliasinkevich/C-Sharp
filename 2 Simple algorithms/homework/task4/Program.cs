// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(System.Console.ReadLine());

// string digits = string.Join(", ", number.ToString().ToCharArray());
// Console.WriteLine(digits);

// или

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int first = number;
string result = string.Empty;
for (; number > 0; number /= 10)
{
    if (number == first) result = number % 10 + " " + result;
    else result = number % 10 + ", " + result;
}

Console.Write(result);

