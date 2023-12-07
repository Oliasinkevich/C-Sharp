// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string str = "aBcD1ef!";

string GetStringToLower(string str)
{
    string LowerCase = str.ToLower();
    return LowerCase;
}

Console.Write(GetStringToLower(str));