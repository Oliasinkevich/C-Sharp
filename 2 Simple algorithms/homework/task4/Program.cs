// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.Write("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());

string digits = string.Join(", ", number.ToString().ToCharArray());
Console.WriteLine(digits);

