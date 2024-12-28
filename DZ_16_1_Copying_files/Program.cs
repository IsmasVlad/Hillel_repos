namespace DZ_16_1_Copying_files
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            try
            {
                Console.Write("Введіть шлях до файлу: ");
                string sourcePath = Console.ReadLine();

                // Перевіряємо, чи існує файл
                FileInfo sourceFile = new FileInfo(sourcePath);
                if (!sourceFile.Exists)
                {
                    Console.WriteLine("Файл не знайдено.");
                    return;
                }

                // Запитуємо у користувача шлях до файлу призначення
                Console.Write("Введіть шлях до папки, в який потрібно скопіювати файл: ");
                string destinationPath = Console.ReadLine();

                // Використовуємо StreamReader для читання та StreamWriter для запису
                using (StreamReader reader = new StreamReader(sourcePath))
                using (StreamWriter writer = new StreamWriter(destinationPath))
                {
                    string content = reader.ReadToEnd();
                    writer.Write(content);
                }

                
                Console.WriteLine("Файл успішно скопійовано!");
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}
