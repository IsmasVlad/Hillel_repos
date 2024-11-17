class Program
{
    static void Main()

    {
        Console.WriteLine("Enter the number of the day of the week (1-7):");
        string dayOfNumber = Console.ReadLine(); 

        if (dayOfNumber == "1")
        {
            Console.WriteLine("Monday");  
        }
        else if (dayOfNumber == "2")
        {
            Console.WriteLine("Tuesday");
        }
        else if (dayOfNumber == "3")
        {
            Console.WriteLine("Wednesday");
        }
        else if (dayOfNumber == "4")
        {
            Console.WriteLine("Thursday");
        }
        else if (dayOfNumber == "5")
        {
            Console.WriteLine("Friday");
        }
        else if (dayOfNumber == "6")
        {
            Console.WriteLine("Satudray");
        }
        else if (dayOfNumber == "7")
        {
            Console.WriteLine("Sunday");
        }
        else 
        { 
            Console.WriteLine("Invalid weekday number.");
        }
    }
}
