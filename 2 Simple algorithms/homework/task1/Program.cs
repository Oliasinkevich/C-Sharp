// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());
if(number % 7 == 0 && number % 23 == 0)System.Console.WriteLine(true);
else {
System.Console.WriteLine($"{false} число {number} не подходит под условие");
}
