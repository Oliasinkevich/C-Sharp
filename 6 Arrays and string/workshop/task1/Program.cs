// Задайте массив символов (тип char []). Создайте строку из символов этого массива.

// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

char[] array = new char[] { 'a', 'b', 'c', 'd' };
char[] array2 = new char[] { 'n', 'r', 'm', 'c', 'g' };

string str = string.Empty;
for (int i = 0; i < array.Length; i++)
{
    str += array[i];
}
Console.Write(str);
Console.WriteLine();

// или

Console.WriteLine(GetCharToString(array2));

string GetCharToString(char[] arr)
{
    string str = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        str+= arr[i];
    }
    return str;
}

