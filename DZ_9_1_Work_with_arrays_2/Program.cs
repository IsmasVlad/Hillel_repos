
// Написати програму, що знаходить другий найбільший елемент масиву.
/*
class Program
{
    static void Main()
    {
        int[] array = { 12, 35, 1, 10, 34, 1 };

        Array.Sort(array); 
        Array.Reverse(array); 

        int largest = array[0]; 
        int secondLargest = int.MinValue;

        foreach (int number in array)
        {
            if (number < largest)
            {
                secondLargest = number;
                break; 
            }
        }

        if (secondLargest == int.MinValue)
        {
            Console.WriteLine("The array has fewer than two unique elements.");
        }
        else
        {
            Console.WriteLine($"The second largest element: {secondLargest}");
        }
    }
}
*/

// Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.

/*
class Program
{
    static void Main()
    {
        
        int[,] array =
        {
            { 12, 5, 7 },
            { 3, 8, 10 },
            { 2, 14, 6 }
        };

        Console.WriteLine("Output array:");
        PrintArray(array);

       
        SortArray(array);

        Console.WriteLine("\nSorted array:");
        PrintArray(array);
    }

    static void SortArray(int[,] array)
    {
        
        int size = array.GetLength(0) * array.GetLength(1);
        int[] tempArray = new int[size];
        int index = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                tempArray[index] = array[i, j];
                index++;
            }
        }

        
        Array.Sort(tempArray);

        
        index = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = tempArray[index];
                index++;
            }
        }
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/

// Написати програму, що буде видаляти з масиву елемент за вказаним індексом.
/*
class Program
{
    static void Main()
    {
       
        int[] array = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Initial array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

       
        Console.Write("Enter the index to delete (0-" + (array.Length - 1) + "): ");
        int index = int.Parse(Console.ReadLine());

        
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Incorrect index!");
            return;
        }

        
        int[] newArray = new int[array.Length - 1];
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (i != index)
            {
                newArray[j] = array[i];
                j++;
            }
        }

        
        Console.WriteLine("Array after deletion:");
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.Write(newArray[i] + " ");
        }
        Console.WriteLine();
    }
}
*/

// Написати програму, що буде знаходити суму елементів по діагоналі у двовимірному масиві.


class Program
{
    static void Main()
    {
        
        int[,] array =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        
        Console.WriteLine("Array:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, i]; 
        }

        
        Console.WriteLine($"Sum of elements along the main diagonal: {sum}");
    }
}