using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        try
        {
            // Ask the user to enter two numbers
            Console.WriteLine("Enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            // We ask what mathematical operation the user wants to perform
            Console.WriteLine("Enter operation (+, -, *, /):");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine(firstNumber + secondNumber);
                    break;
                case "-":
                    Console.WriteLine(firstNumber - secondNumber);
                    break;
                case "*":
                    Console.WriteLine(firstNumber * secondNumber);
                    break;
                case "/":
                    Console.WriteLine(firstNumber / secondNumber);
                    break;
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error division by zero is impossiblee!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
        finally
        {
            Console.WriteLine("The program is complete");
        }

    }
}



