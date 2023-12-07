// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько среди введённых букв гласных.

// Пример

// “hello” => 2
// “world” => 1

Console.Write("Введите что-нибудь ");
Console.WriteLine();

string str = Console.ReadLine().ToLower();

int GetCharToString(string str)
{
    char[] array = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
    int count = 0;

    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (str[i] == array[j])
            {
                count++;
            }
        }
    }
    return count;
}

Console.Write(GetCharToString(str));
