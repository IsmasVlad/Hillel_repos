// План реалізації:
// 1. Створити клас TodoList для представлення окремої справи.
// 2. Створити список для зберігання об'єктів TodoList.
// 3. Написати методи для додавання, відображення, позначення виконання та видалення справ.
// 4. Реалізувати меню для взаємодії з користувачем.
// 5. Обробити можливі помилки, такі як некоректний ввід.


using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    class TodoList
    {
        public string Title 
        {
            get;
            set;
        }
        public bool IsCompleted
        {
            get;
            set;
        }
        public TodoList(string title)
        {
            Title = title;
            IsCompleted = false;
        }
    }
    static List<TodoList> todoList = new List<TodoList>();
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        while (true)
        {
            ShowMenu();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddTodo();
                    break;
                case "2":
                    ShowTodo();
                    break;
                case "3":
                    MarkAs();
                    break;
                case "4":
                    DeleteTodo();
                    break;
                case "5":
                    Console.WriteLine("Вихід із програми. Дякуємо!");
                    return;
                default:
                    Console.WriteLine("Некоректний вибір. Спробуйте ще раз.");
                    break;
            }

        }

    }
    static void ShowMenu()
    {
        Console.WriteLine("\nМеню списку справ:");
        Console.WriteLine("1. Додати справу");
        Console.WriteLine("2. Показати всі справи");
        Console.WriteLine("3. Відмітити справу як виконану");
        Console.WriteLine("4. Видалити справу");
        Console.WriteLine("5. Вийти");
        Console.Write("Ваш вибір: ");
    }
    static void AddTodo()
    {
        Console.Write("Введіть назву справи: ");
        string title = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(title))
        {
            todoList.Add(new TodoList(title));
            Console.WriteLine("Справу додано до списку.");
        }
        else
        {
            Console.WriteLine("Назва справи не може бути порожньою.");
        }
    }
    static void ShowTodo()
    {
        {
            if (todoList.Count == 0)
            {
                Console.WriteLine("Список справ порожній.");
            }
            else
            {
                Console.WriteLine("Список справ:");
                for (int i = 0; i < todoList.Count; i++)
                {
                    string status = todoList[i].IsCompleted ? "[Виконано]" : "[Не виконано]";
                    Console.WriteLine($"{i + 1}. {status} {todoList[i].Title}");
                }
            }
        }
    }
    static void MarkAs()
    {
        ShowTodo();
        Console.Write("Введіть номер справи для відмітки: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todoList.Count)
        {
            todoList[index - 1].IsCompleted = true;
            Console.WriteLine("Справу позначено як виконану.");
        }
        else
        {
            Console.WriteLine("Некоректний номер справи.");
        }
    }
    static void DeleteTodo()
    {
        ShowTodo();
        Console.Write("Введіть номер справи для видалення: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todoList.Count)
        {
            todoList.RemoveAt(index - 1);
            Console.WriteLine("Справу видалено.");
        }
        else
        {
            Console.WriteLine("Некоректний номер справи.");
        }
    }
}