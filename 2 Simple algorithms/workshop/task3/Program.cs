// Напишите программу, которая будет принимать на вход двачисла и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

Console.Write("Введите число 1: ");
int a = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(System.Console.ReadLine());
if(a%b==0)System.Console.WriteLine(true);
else {
System.Console.WriteLine($"{false} {a%b}");
}

