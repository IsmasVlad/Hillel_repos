internal class Program
{
    static char[,] array = new char[3, 3];
    static char currentPlayer = 'X';
    static int moveCount = 0;
    static bool gameRunning = true;

    static void Main()
    {
        // Заповнення масиву числами від 1 до 9
        int counter = 1;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = (char)('1' + counter - 1); // Додаємо '1' до числа
                counter++;
            }
        }

        // Головний цикл 
        while (gameRunning)
        {
            Console.Clear();
            PrintBoard();
            Console.WriteLine($"Player {currentPlayer}, make your move (1-9): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int move) && move >= 1 && move <= 9 && array[(move - 1) / 3, (move - 1) % 3] != 'X' && array[(move - 1) / 3, (move - 1) % 3] != 'O')
            {
                array[(move - 1) / 3, (move - 1) % 3] = currentPlayer;
                moveCount++;

                if (CheckWin())
                {
                    Console.Clear();
                    PrintBoard();
                    Console.WriteLine($"The Player {currentPlayer} won!");
                    gameRunning = false;
                }
                else if (CheckDraw())
                {
                    Console.Clear();
                    PrintBoard();
                    Console.WriteLine("Draw!");
                    gameRunning = false;
                }
                else
                {
                    currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
                }
            }
            else
            {
                Console.WriteLine("Wrong move. Try again..");
                Console.ReadKey();
            }
        }
    }

    // Метод для відображення масиву у вигляді ігрового поля
    static void PrintBoard()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(" " + array[i, j] + " ");

                // Додаємо вертикальні лінії між клітинками, окрім останньої
                if (j < array.GetLength(1) -1)
                    Console.Write("|");
            }
            Console.WriteLine(); // Перехід на новий рядок

            // Додаємо горизонтальні лінії між рядками, окрім останнього
            if (i < array.GetLength(0) - 1)
            {
                Console.WriteLine("--- --- ---");
            }
        }
    }

    // Перевірка на виграш
    static bool CheckWin()
    {
        int[,] winningCombinations = new int[,]
        {
            {0, 1, 2}, {3, 4, 5}, {6, 7, 8}, // Горизонталі
            {0, 3, 6}, {1, 4, 7}, {2, 5, 8}, // Вертикалі
            {0, 4, 8}, {2, 4, 6}             // Діагоналі
        };

        // Перевірка всіх комбінацій
        for (int i = 0; i < winningCombinations.GetLength(0); i++)
        {
            int row1 = winningCombinations[i, 0] / 3;
            int col1 = winningCombinations[i, 0] % 3;
            int row2 = winningCombinations[i, 1] / 3;
            int col2 = winningCombinations[i, 1] % 3;
            int row3 = winningCombinations[i, 2] / 3;
            int col3 = winningCombinations[i, 2] % 3;

            if (array[row1, col1] == currentPlayer &&
                array[row2, col2] == currentPlayer &&
                array[row3, col3] == currentPlayer)
            {
                return true; // Гравець виграв
            }
        }
        return false;
    }

    // Перевірка на нічийну гру
    static bool CheckDraw()
    {
        return moveCount == 9; // Якщо 9 ходів, нічия
    }
}