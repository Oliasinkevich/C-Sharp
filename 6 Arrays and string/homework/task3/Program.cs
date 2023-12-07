// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

string str1 = "aBcD1ef!";
string str2 = "шалаш";
string str3 = "55655";

bool isTrueOrFalse(string str)
{
    bool Paralindrom = default;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == str[str.Length-i-1])
        {
            Paralindrom = true;
        }
        else
        {
            Paralindrom = false;
        }
    }
    return Paralindrom;
}

Console.WriteLine(isTrueOrFalse(str1));
Console.WriteLine(isTrueOrFalse(str2));
Console.WriteLine(isTrueOrFalse(str3));