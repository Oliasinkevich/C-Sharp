// Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки.

// Указание
// Использовать рекурсию. Не использовать цикл.

// Пример

// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

Console.Write("Введите что-нибудь ");
Console.WriteLine();

string str = Console.ReadLine().ToLower();

void PrintConsonants(string str, int index)
{
    if (index < str.Length) 
    {
        char currentValue = str[index];
        if ("bcdfghjklmnpqrstvwxyz".Contains(currentValue)) 
        {
            Console.Write(currentValue + " "); 
        }
        PrintConsonants(str, index + 1); 
    }
}

Console.WriteLine("Согласные буквы в строке:");
PrintConsonants(str, 0); 
