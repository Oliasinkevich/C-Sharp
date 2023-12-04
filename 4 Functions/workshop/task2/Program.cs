// Задайте массив из N случайных целых чисел (N вводится с клавиатуры).

// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.

// Пример

// [1 5 11 21 81 4 0 91 2 3]

// => 2

int[] FillArray(int[] arr)
{
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rand.Next(1, 100);
}
return arr;
}
void PrintArray(int[] arr)
{
foreach (int item in arr) System.Console.Write(item + "/");
System.Console.WriteLine();
}

System.Console.WriteLine("Введите количество элементов");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];


array = FillArray(array);
PrintArray(array);

//задача 1, колво простых числе в массиве
bool PrimeCheck(int x)
{
for (int i = 2; i < x; i++)
if (x % i == 0) return false;
return true;
}
int count2 = 0;
foreach (int item in array)
if (PrimeCheck(item))
{
count2++;
System.Console.Write(item + "/");
}
System.Console.WriteLine(" Простых чисел в данном массиве: " + count2);

//задача 2 Найдите количество чисел, которые оканчиваются на 1 и
//делятся нацело на 7.
int Task2(int[] arr)
{
int count=0;
foreach(int item in arr)
if(item%7==0 & item%10==1)
{
count++; System.Console.Write(item+"/");
}
return count;
}
System.Console.WriteLine("Результат: "+Task2(array));
