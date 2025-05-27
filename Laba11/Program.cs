/*
using System;
using System.Collections.Generic;

class SupportRequestApp
{
    static Queue<string> requestQueue = new Queue<string>();

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Додати заявку");
            Console.WriteLine("2. Обробити заявку");
            Console.WriteLine("3. Подивитися першу заявку");
            Console.WriteLine("4. Показати всі заявки");
            Console.WriteLine("5. Вийти");
            Console.Write("Виберіть опцію: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddRequest();
                    break;
                case "2":
                    ProcessRequest();
                    break;
                case "3":
                    PeekRequest();
                    break;
                case "4":
                    ShowAllRequests();
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Програма завершена.");
                    break;
                default:
                    Console.WriteLine("Невірна опція. Спробуйте ще раз.");
                    break;
            }
        }
    }
    static void AddRequest()
    {
        Console.Write("Введіть текст заявки: ");
        string request = Console.ReadLine();
        requestQueue.Enqueue(request);
        Console.WriteLine("Заявку додано!");
    }

    static void ProcessRequest()
    {
        if (requestQueue.Count > 0)
        {
            string processedRequest = requestQueue.Dequeue();
            Console.WriteLine($"Заявка \"{processedRequest}\" оброблена!");
        }
        else
        {
            Console.WriteLine("Черга порожня.");
        }
    }
    static void PeekRequest()
    {
        if (requestQueue.Count > 0)
        {
            Console.WriteLine($"Перша заявка в черзі: \"{requestQueue.Peek()}\"");
        }
        else
        {
            Console.WriteLine("Черга порожня.");
        }
    }

    static void ShowAllRequests()
    {
        if (requestQueue.Count > 0)
        {
            Console.WriteLine("Усі заявки в черзі:");
            foreach (string request in requestQueue)
            {
                Console.WriteLine($"- {request}");
            }
        }
        else
        {
            Console.WriteLine("Черга порожня.");
        }
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class WordFrequencyAnalyzer
{
    static void Main()
    {
        Console.WriteLine("Введіть текст:");
        string inputText = Console.ReadLine();

        string cleanedText = Regex.Replace(inputText.ToLower(), @"[^\w\s]", ""); 
        string[] words = cleanedText.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        var sortedWords = wordCount.OrderByDescending(pair => pair.Value);

        Console.WriteLine("\nСтатистика слів:");
        foreach (var pair in sortedWords)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
