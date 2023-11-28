// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. Программа должна выдать ответ: Да/Нет.

// Примеры

// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

int [] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10, 90);
    Console.Write(array[i] + " ");
}

Console.Write("Введите число для поиска: ");
int findValue = Convert.ToInt32(Console.ReadLine());
bool flag = false;
foreach (int item in array)
{
    if (item == findValue)
    {
        flag = true;
    }
}
if (flag)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}


