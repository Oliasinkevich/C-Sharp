// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.Write("Введите координатную точку Х: ");
int x = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите координатную точку Y: ");
int y = Convert.ToInt32(System.Console.ReadLine());
int result = 0;
if (x > 0 && y > 0)
{
    result = 1;
}
else if (x < 0 && y > 0)
{
    result = 2;
}
else if (x < 0 && y < 0)
{
    result =3;
}
else
{
    result = 4;
}

Console.WriteLine($"Точка с координатами ({x}, {y}) находится в {result} координатной четверти.");
