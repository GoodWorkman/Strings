/*Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения,  которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
 * 
 * 
 */

using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Message.message = "Это обычное сообщение которое ничего не значит и не имеет запятых";
    }
}

public static class Message
{
    public static string message = "";

    public static void PrintModifiedMessage(int n)
    {
        string[] words = message.Split(" ");

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length <= n)
            {
                Console.Write(words[i] + " ");
            }
        }
    }

    public static void PrintWordsWithoutLastSign(char sign)
    {
        string[] words = message.Split(" ");

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i][words[i].Length - 1] != sign)
            {
                Console.Write(words[i] + " ");
            }
        }
    }

    public static void PrintLongestWord()
    {
        string[] words = message.Split(" ");
        string result = words[0];

        for (int i = 0; i < words.Length; i++)
        {
            if (result.Length < words[i].Length)
            {
                result = words[i];
            }
        }
        Console.Write(result);
    }

    public static void PrintLongestWords()
    {
        string[] words = message.Split(" ");
        string result = words[0];

        for (int i = 0; i < words.Length; i++)
        {
            if (result.Length < words[i].Length)
            {
                result = words[i];
            }
        }
        StringBuilder stringBuilder = new StringBuilder(result + " " + result);
        Console.Write(result);
    }
}


