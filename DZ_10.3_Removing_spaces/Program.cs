//ДЗ 10.3. Видалення пробілiв.
/*
class Program
{
    static void Main()
    {
        
        string input = "Number1, Number2, Number3, Number4";

        
        string result = input.Replace(" ", "");

        
        Console.WriteLine("A string without spaces: " + result);
    }
}
*/

//ДЗ 10.2. Видалення пробілiв.

/*
using System.Text;

class Program
{
    static void Main()
    {
        
        StringBuilder report = new StringBuilder();

        
        report.AppendLine("Event Report");
        report.AppendLine($"Date: {DateTime.Now.ToShortDateString()}\n");

        
        report.AppendLine("Event List:");

        
        string eventInput;
        while (true)
        {
            Console.WriteLine("Enter an event (or type 'exit' to finish):");
            eventInput = Console.ReadLine();

            
            if (eventInput.ToLower() == "exit")
            {
                break;
            }

            
            report.AppendLine($"- {eventInput}");
        }

        
        Console.WriteLine("\nFinal Report:");
        Console.WriteLine(report.ToString());
    }
}

*/

// ДЗ 10.1. Перевiрити ім’я та прізвище.
//class Program
//{
//    static void Main()
//    {

//        Console.WriteLine("Enter your first and last name (separated by a space):");
//        string fullName = Console.ReadLine();


//        string[] nameParts = fullName.Split(' ');


//        if (nameParts.Length == 2)
//        {
//            string firstName = nameParts[0];
//            string lastName = nameParts[1];


//            if (char.ToUpper(firstName[0]) == char.ToUpper(lastName[0]))
//            {
//                Console.WriteLine("Last name starts with the same letter as first name");
//            }
//            else
//            {
//                Console.WriteLine("Last name does not start with the same letter as first name");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Please enter a correct first and last name.");
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        // Загаданное слово
        string word = "програмування";

        // Используем коллекции
        HashSet<char> guessedLetters = new HashSet<char>(); // Угаданные буквы
        HashSet<char> wrongLetters = new HashSet<char>();   // Неправильные буквы
        Dictionary<char, List<int>> letterPositions = new Dictionary<char, List<int>>(); // Позиции букв
        StringBuilder hiddenWord = new StringBuilder(new string('_', word.Length)); // Скрытое слово
        int attempts = 6; // Количество попыток

        // Инициализация словаря позиций
        for (int i = 0; i < word.Length; i++)
        {
            char letter = word[i];
            if (!letterPositions.ContainsKey(letter))
                letterPositions[letter] = new List<int>();
            letterPositions[letter].Add(i);
        }

        Console.WriteLine("Добро пожаловать в игру 'Шибениця'!");

        while (attempts > 0 && hiddenWord.ToString().Contains('_'))
        {
            // Вывод текущего состояния игры
            Console.WriteLine($"\nСлово: {hiddenWord}");
            Console.WriteLine($"Осталось попыток: {attempts}");
            Console.WriteLine($"Угаданные буквы: {string.Join(", ", guessedLetters)}");
            Console.WriteLine($"Ошибочные буквы: {string.Join(", ", wrongLetters)}");
            Console.Write("Введите букву: ");
            char guess = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Проверка, была ли буква уже введена
            if (guessedLetters.Contains(guess) || wrongLetters.Contains(guess))
            {
                Console.WriteLine("Вы уже вводили эту букву.");
                continue;
            }

            // Проверка буквы
            if (letterPositions.ContainsKey(guess))
            {
                Console.WriteLine("Правильно!");
                guessedLetters.Add(guess);

                // Открываем буквы в скрытом слове
                foreach (int position in letterPositions[guess])
                {
                    hiddenWord[position] = guess;
                }
            }
            else
            {
                Console.WriteLine("Неправильно!");
                wrongLetters.Add(guess);
                attempts--;
            }
        }

        // Завершение игры
        if (!hiddenWord.ToString().Contains('_'))
        {
            Console.WriteLine($"\nПоздравляем! Вы угадали слово: {word}!");
        }
        else
        {
            Console.WriteLine($"\nВы проиграли. Загаданное слово было: {word}.");
        }
    }
}