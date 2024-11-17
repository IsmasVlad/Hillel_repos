class Program
{
    static void Main()
    {
        // Ask the user to enter two numbers
        Console.WriteLine("Enter the first number:");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

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
                // Check for division by zero
                if (secondNumber != 0)
                {
                    Console.WriteLine($"Solution: {firstNumber / secondNumber}");
                }
                else
                {
                    Console.WriteLine(firstNumber + secondNumber);
                }
                break;

            default:
                Console.WriteLine("Unknown operation");
                break;
        }      
    }
}



