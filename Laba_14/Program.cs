using System;
using System.IO;
using System.Threading.Tasks;
using System;

class Program
{
    public static void GenerateLogs()
    {
        string[] fileNames = { "log1.txt", "log2.txt", "log3.txt" };
        Random rnd = new Random();

        foreach (var file in fileNames)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                for (int i = 0; i < 10000; i++)
                {
                    if (rnd.Next(0, 5) == 0)
                        writer.WriteLine($"[{DateTime.Now}] ERROR: Something went wrong.");
                    else
                        writer.WriteLine($"[{DateTime.Now}] INFO: All systems operational.");
                }
            }
            Console.WriteLine($"Файл {file} створено.");
        }
    }
    static void Main()
    {
        GenerateLogs();

        // Масив файлів для обробки
        string[] fileNames = { "log1.txt", "log2.txt", "log3.txt" };

        // Створюємо масив задач
        Task[] tasks = new Task[fileNames.Length];

        // Запуск обробки кожного файлу в окремій задачі
        for (int i = 0; i < fileNames.Length; i++)
        {
            int fileIndex = i; // Локальна змінна для кожної задачі
            tasks[i] = Task.Run(() => ProcessFile(fileNames[fileIndex]));
        }

        // Чекаємо завершення всіх задач
        Task.WhenAll(tasks).Wait();

        Console.WriteLine("Обробка файлів завершена!");

    }

    static void ProcessFile(string fileName)
    {
        int errorCount = 0;

        try
        {
            // Читання рядків з файлу
            var lines = File.ReadAllLines(fileName);

            // Підрахунок рядків з "ERROR"
            foreach (var line in lines)
            {
                if (line.Contains("ERROR", StringComparison.OrdinalIgnoreCase))
                {
                    errorCount++;
                }
            }
            Console.WriteLine($"Файл {fileName}: знайдено {errorCount} помилок.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка при обробці файлу {fileName}: {ex.Message}");
        }
    }
}
