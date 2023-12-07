// На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.

// Указание
// Метод строки ToCharArray() не использовать.

// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

string str = "Hello!";

char[] GetStringToChar(string str)
{
    char[] array = new char[str.Length];

    for (int i = 0; i < str.Length; i++)
    {
        array[i] = str[i];
    }
    return array;
}

Console.WriteLine(String.Join(" ", GetStringToChar(str)));
