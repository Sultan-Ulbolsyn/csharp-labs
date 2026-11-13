
using System;

class Program
{
    static string ConvertLetters(string text, out int count)
    {
        string result = "";
        count = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (char.IsUpper(ch))
            {
                count++;
                ch = char.ToLower(ch);
            }

            result += ch;
        }

        return result;
    }

    static void Main()
    {
        string text;

        do
        {
            Console.Write("Мәтін енгізіңіз: ");
            text = Console.ReadLine() ?? "";
        }
        while (text.Length == 0);

        int count;
        string result = ConvertLetters(text, out count);

        Console.WriteLine("Бастапқы мәтін: " + text);
        Console.WriteLine("Өзгертілген мәтін: " + result);
        Console.WriteLine("Бас әріптер саны: " + count);
    }
}

