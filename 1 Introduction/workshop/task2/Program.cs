// Напишите программу, которая на вход принимает 
// целое число N, а на выходе показывает все целые 
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2


Console.WriteLine("введите число:");
int number = Convert.ToInt32(System.Console.ReadLine());

// for(int i=-1*number; i<=number; i++)
// {
//     System.Console.Write(i+" ");
// }
int num = number * -1;
while (num <= number)
{
    System.Console.Write(num + " ");
    num++;
}

