/*Создать программу, которая будет проверять корректность ввода логина. 
 * Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
 * при этом цифра не может быть первой:
а) без использования регулярных выражений;
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
        Solve();
    }

    static void Solve()
    {
        string password = Console.ReadLine();
        Console.WriteLine(IsCorrectPassword(password) ? "Password is correct!" : "Password is not correct!");
    }

    static bool IsCorrectPassword(string password)
    {
        if (password.Length < 2 || password.Length > 9) return false;
        if (char.IsDigit(password[0])) return false;

        foreach (char w in password)
        {
            if (!IsEnglishWord(w) && !char.IsDigit(w))
            {
                return false;
            }
        }

        return true;
    }

    static bool IsEnglishWord(char word)
    {
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        bool result = false;
        foreach (char w in alphabet)
        {
            if (w == char.ToUpper(word))
            {
                result = true;
            }
        }
        return result;

    }
}



