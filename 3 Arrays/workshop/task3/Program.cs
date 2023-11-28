// Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новый массив.

// Пример

// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

int [] array = new int[11];
int [] newArray = new int[array.Length / 2];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 11);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < array.Length / 2; i++)
{
    newArray[i] = array[i]*array[array.Length-1-i];
    Console.Write(newArray[i] + " ");
}
