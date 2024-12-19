using System;

namespace FibonacciApp
{
    public static class FiboCalc
    {
        public static int GetFibonacciNumber(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;


            return GetFibonacciNumber(n - 1) + GetFibonacciNumber(n - 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Fibonacci number: ");
            int number = int.Parse(Console.ReadLine());
            int result = FiboCalc.GetFibonacciNumber(number);
            Console.WriteLine($"Fibonacci number order {number} complies {result}");
        }
    }
}