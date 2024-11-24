// 1. Обчислення середнього заробітку: 
//Напишіть програму, яка запитує користувача про зарплату кожного працівника за місяць. 
//Після отримання всіх значень програма має обчислити та вивести середній заробіток.

/*
class Program
{
    static void Main()
    {
        decimal Salary = 0;
        int employeeCount = 0;

        Console.WriteLine("Enter the employee's salary. To finish, enter 'stop'.");

        while (true)
        {
            Console.Write($"Employee salary #{employeeCount + 1}: ");
            string input = Console.ReadLine();


            if (input == "stop")
                break;

            try
            {
                Salary += Convert.ToDecimal(input);
                employeeCount++;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid salary entered. Please enter a valid number.");
            }
        }

        if (employeeCount > 0)
        {
            decimal averageSalary = Salary / employeeCount;
            Console.WriteLine($"\nAverageSalary: {averageSalary:C}");
        }
        else
        {
            Console.WriteLine("Salaries were not introduced.");
        }
    }
}
*/



//2. Побудова графіку зірочками:
//Напишіть програму, яка будує графік за допомогою зірочок. 
//Користувач повинен ввести кількість рядків графіка. 
//Кожен рядок графіка має містити відповідну кількість зірочок.

/*
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows for the graph");
        int rows= Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i<= rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();    
        }
    }
}
*/

//3. Генерація простих чисел:
//Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа. 
//Просте число - це число, яке ділиться лише на 1 і на себе.


/*
class Program
{
    static void Main()
    {
        Console.Write("Enter the upper limit for prime numbers: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"Prime numbers from 1 to {num}:");

        for (int i = 2; i <= num; i++) // We go through the numbers from 2 to num
        {
            bool isPrime = true; // A variable to check if a number is prime

            for (int j = 2; j < i; j++) // We check the divisibility of the number i
            {
                if (i % j == 0) // If a number is divisible without a remainder, it is not prime
                {
                    isPrime = false; 
                    break; 
                }
            }

            if (isPrime)
            {
                Console.Write($"{i} ");
            }
        }
    }
}

*/

//4. Перевірка паролю: 
//Напишіть програму, яка перевіряє пароль користувача.
//Пароль вважається прийнятним, якщо він містить принаймні 8 символів,
//з яких принаймні один символ - це цифра, а також принаймні один символ - це спеціальний символ (наприклад, !, @, # тощо).

/*
class Program
{
    static void Main()
    {
        string password; 

        do
        {
            Console.WriteLine("Enter the correct password:");
            password = Console.ReadLine(); 
        }
        while (password != "1234567@"); 

        Console.WriteLine("Password is correct!"); 
    }
}
*/

// 5. Генерація фібоначчівської послідовності:
//Напишіть програму, яка генерує перші N чисел Фібоначчі. 
//Послідовність Фібоначчі починається з 0 і 1, а кожне наступне число є сумою двох попередніх чисел у послідовності.


/*
class Program
{
    static void Main()
    {
        Console.Write("Enter the number of Fibonacci terms to display: ");
        int n = int.Parse(Console.ReadLine());
        int a = 0, b = 1;
        Console.WriteLine("Fibonacci sequence:");

        // We use the for loop to output the sequence
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a);  // Output the current number
            int next = a + b;  // The next number in the sequence
            a = b;  // Shifting the numbers
            b = next;  // New value b
        }
    }
}
*/

// 6. Калькулятор оплати праці за годину: 
//Напишіть програму, яка запитує в користувача кількість годин, працюваних за день, та розмір годинної ставки. 
//Після введення значень програма має обчислити та вивести оплату за день.

/*
class Program
{
    static void Main()
    {
        do
        {
            Console.WriteLine("Enter number of hours worked per day: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter hourly rate");
            int rate = Convert.ToInt32(Console.ReadLine());
            int Summ = rate * number;
            Console.WriteLine("Payment per day = " + Summ + "$");
        }
        while (true);   
    }
}

*/

// 7. Генерація таблиці множення для конкретного числа: 
//Напишіть програму, яка запитує в користувача число, а потім генерує таблицю множення для цього числа від 1 до 10.

/*
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter any number:");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i<=10; i++)
        {
            int Summ = num * i;
            Console.WriteLine(num + "*" + i + "=" + Summ);    
        }
    }
}
*/

// 8. Перевірка на простоту: 
//Напишіть програму, яка перевіряє, чи є задане користувачем число простим.
//Число вважається простим, якщо воно ділиться лише на 1 і на себе.


class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num <= 1)
        {
            Console.WriteLine("Not prime");
            return;
        }

        for (int i = 2; i <= num/2; i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine("Not prime");
                return;
            }
        }

        Console.WriteLine("Prime");
    }
}
