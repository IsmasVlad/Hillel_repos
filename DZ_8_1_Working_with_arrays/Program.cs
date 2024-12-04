/*
1. Створити масив із 10 елементів типу int. 
їм випадкові значення від -10 до 10, використовуючи клас Random 
 Вивести на екран елементи масиву з парним індексом. (не парні значення, а саме парні індекси!!)


/*
namespace DZ_8_1_Working_with_arrays
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random(); 
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10,11) ;
            }
            Console.WriteLine("Array:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\nElements with even index:");
            for (int i = 0; i < array.Length; i += 2)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
*/
/*
2. Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число.
*/
/*
internal class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-10, 11);
        }
        Console.WriteLine("Array:");

        Console.WriteLine("Array:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }

        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        Console.WriteLine($"\nSum of elements: {sum}");
        if (sum >= 0)
        {
            Console.WriteLine("The sum is non-negative.");
        }
        else
        {
            Console.WriteLine("The sum is negative.");
        }
        Console.WriteLine("\nElements with even index:");
        for (int i = 0; i < array.Length; i += 2)
        {
            Console.Write(array[i] + " ");
        }
    }
}
*/

/*
4 Створити двовимірний масив 5х5. Заповнити його будь-якими числами. Визначити та вивести на екран:
а) максимальний елемент масиву; 
б) мінімальний елемент масиву; 
в) координати мінімального елемента масиву. 
г) координати максимального елемента масиву.
*/

/*
internal class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[,] array = new int[5, 5];
        Console.WriteLine(array.Length);

        //Fill the array with random numbers
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rand.Next(-10, 11);
            }
        }
        // Output the array
        Console.WriteLine("Array:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
        // Find the maximum and minimum elements and their coordinates

        int maxValue = array[0, 0];
        int minValue = array[0, 0];
        int maxRow = 0, maxCol = 0;
        int minRow = 0, minCol = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] > maxValue)
                {
                    maxValue = array[i, j];
                    maxRow = i;
                    maxCol = j;
                }
                if (array[i, j] < minValue)
                {
                    minValue = array[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }
        Console.WriteLine("\nMaximum element: " + maxValue);
        Console.WriteLine("Coordinates of maximum element: (" + maxRow + ", " + maxCol + ")");

        Console.WriteLine("\nMinimum element: " + minValue);
        Console.WriteLine("Coordinates of minimum element: (" + minRow + ", " + minCol + ")");
    }
}
*/

//5. За допомогою enum створити програму, що буде запитувати у користувача кількість днів,
//а потім рахувати який буде день через введену кількість, якщо рахувати від понеділка і виводити результат.

/*
class Program
{
    enum DayOfWeek
    {
        Monday=1,    // 1
        Tuesday,   // 2
        Wednesday, // 3
        Thursday,  // 4
        Friday,    // 5
        Saturday,  // 6
        Sunday     // 7
    }

    static void Main()
    {
        
        Console.Write("Enter the number of days: ");
        int days = int.Parse(Console.ReadLine());

        
        DayOfWeek day = (DayOfWeek)(days % 8);

        
        Console.WriteLine($"The day is: {day}");
    }
}
*/

//3. Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення
// у першому рядку мають бути записані добутки кожного з чисел від 1 до 9 на 1, у другому – на 2, ...,
//в останньому – на 9). Тобто в 1 строчці будуть значення від 1 до 9, а у другому 2,4,6,....,18 і т.д.

internal class Program
{
    static void Main()
    {

        int[,] array = new int[10, 10];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 1; j < array.GetLength(1); j++)
            {
                array[i, j] = i * j; ;
            }
        }
        Console.WriteLine("Array:");
        for (int i = 1; i < array.GetLength(0); i++)
        {
            for (int j = 1; j < array.GetLength(1); j++) 
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
    