// Вывести четные числа

// Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.

// number = 5 -> 2    4

// number = 8 -> 2    4    6    8

using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
        int min = 2;
        while (min <= number)
        {
            Console.Write(min + "\t");
            min = min + 2;
        }
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 16;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}