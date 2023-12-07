// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

// “Hello my world” => “world my Hello”

string str = "Hello my world";

string ReverseString(string str)
{
    string[] words = str.Split(' '); // Разделение строки на слова
    Array.Reverse(words); // Обратное расположение слов
    string reversedStr = string.Join(' ', words); // Объединение слов с пробелами между ними

    return reversedStr;
}

Console.WriteLine(ReverseString(str));