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
class Program
{
    static void Main()
    {
        
        Console.WriteLine("Enter your first and last name (separated by a space):");
        string fullName = Console.ReadLine();

        
        string[] nameParts = fullName.Split(' ');

        
        if (nameParts.Length == 2)
        {
            string firstName = nameParts[0];
            string lastName = nameParts[1];

            
            if (char.ToUpper(firstName[0]) == char.ToUpper(lastName[0]))
            {
                Console.WriteLine("Last name starts with the same letter as first name");
            }
            else
            {
                Console.WriteLine("Last name does not start with the same letter as first name");
            }
        }
        else
        {
            Console.WriteLine("Please enter a correct first and last name.");
        }
    }
}