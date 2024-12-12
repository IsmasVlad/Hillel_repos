using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        string word = "hillel";
        HashSet<char> wordSet = new HashSet<char>(word);
        HashSet<char> wrongLetters = new HashSet<char>();
        List<char> correctGuesses = new List<char>(new char[word.Length]);
        int wrongAttempts = 0;
        int maxAttempts = 6;
        Console.WriteLine("Вітаємо! Спробуйте вгадати зашифроване слово!");
        Console.WriteLine("Кількість літер у слові: 6 ");
        Console.WriteLine("Кількість можливих невірних спроб: " + maxAttempts);
        for (int i = 0; i < word.Length; i++)
        {
            correctGuesses[i] = '_';
        }

        while (wrongAttempts < maxAttempts && correctGuesses.Contains('_'))
        {
            Console.Write("Введіть літеру: ");
            char guessedLetter;
            try
            {
                guessedLetter = char.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Будь ласка, введіть одну літеру!");
                continue;
            }
            if (wrongLetters.Contains(guessedLetter) || correctGuesses.Contains(guessedLetter))
            {
                Console.WriteLine("Ви вже вводили цю літеру!");
                continue;
            }

            if (wordSet.Contains(guessedLetter))
            {
                Console.WriteLine("Літера є в слові!");
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == guessedLetter)
                    {
                        correctGuesses[i] = guessedLetter;
                    }
                }
            }
            else
            {
                Console.WriteLine("Літера відсутня в слові!");
                wrongLetters.Add(guessedLetter);
                wrongAttempts++;
                Console.WriteLine($"Кількість помилок: {wrongAttempts} з {maxAttempts}");
            }
            Console.WriteLine("Неправильні літери: " + string.Join(", ", wrongLetters));
        }

        if (correctGuesses.Contains('_'))
        {
            Console.WriteLine($"Ви програли! Слово було: {word}");
        }
        else
        {
            Console.WriteLine($"Вітаємо! Ви відгадали слово! Зашифроване слово: {word}");
            Console.WriteLine("Дякуємо за гру.");
        }
    }
}

