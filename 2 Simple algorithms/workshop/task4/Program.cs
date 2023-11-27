// Напишите программу, которая выводит третью с конца цифру заданного числа или сообщает, что третьей цифры нет.


// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(System.Console.ReadLine());
if (number / 100 > 0)
{
    Console.WriteLine( number / 100 % 10);
}
else 
{
    Console.WriteLine("Цифры нет");
}