class Program
{
    static void Main()
    {
        Console.WriteLine("Enter any number:");
        string input = Console.ReadLine();

        try
        {
            int intValue = int.Parse(input);
            Console.WriteLine($"Successfully converted to int: {intValue}");
        }

        catch (FormatException)
        {
            Console.WriteLine("Incorret format for int.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Value too large or small for int.");
        }
        try
        {
            double doubleValue = double.Parse(input);
            Console.WriteLine($"Successfully converted to double: {doubleValue}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Incorret format for double.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Value too large or small for double.");
        }
        try
        {
            float floatValue = float.Parse(input);
            Console.WriteLine($"Successfully converted to float: {floatValue}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Incorret format for float.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Value too large or small for float.");
        }
        try
        {
            decimal decimalValue = decimal.Parse(input);
            Console.WriteLine($"Successfully converted to decimal: {decimalValue}");
        }

        catch (FormatException ) 
        {
            Console.WriteLine("Incorret format for decimal.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Value too large or small for decimal.");
        }
    }
}