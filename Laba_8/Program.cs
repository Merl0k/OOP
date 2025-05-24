/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 12, 15, 7, 20, 33, 50, 8, 11, 90, 45 };
        int sum = 0;

        Console.WriteLine("Числа, які діляться на 3 або 5:");

        foreach (int number in numbers)
        {
            if (number % 3 == 0 || number % 5 == 0)
            {
                Console.Write(number + " ");
                sum += number;
            }
        }

        Console.WriteLine("\nСума цих чисел: " + sum);
    }
}
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        string[] productNames = { "Хліб", "Молоко", "Яблука", "Сир", "Шоколад", "Кава", "Чай" };
        double[] productPrices = { 25.5, 32.0, 45.3, 120.0, 80.0, 150.0, 75.5 };

        double sum = 0;
        for (int i = 0; i < productPrices.Length; i++)
        {
            sum += productPrices[i];
        }
        double averagePrice = sum / productPrices.Length;
        Console.WriteLine($"Середня ціна товарів: {averagePrice:F2}");

        Console.WriteLine("\nТовари, ціна яких перевищує середню:");
        for (int i = 0; i < productPrices.Length; i++)
        {
            if (productPrices[i] > averagePrice)
            {
                Console.WriteLine($"{productNames[i]} - {productPrices[i]}");
            }
        }

        double minPrice = productPrices[0];
        double maxPrice = productPrices[0];
        int minIndex = 0;
        int maxIndex = 0;

        for (int i = 1; i < productPrices.Length; i++)
        {
            if (productPrices[i] < minPrice)
            {
                minPrice = productPrices[i];
                minIndex = i;
            }
            if (productPrices[i] > maxPrice)
            {
                maxPrice = productPrices[i];
                maxIndex = i;
            }
        }

        Console.WriteLine($"\nНайдешевший товар: {productNames[minIndex]} - {minPrice}");
        Console.WriteLine($"Найдорожчий товар: {productNames[maxIndex]} - {maxPrice}");
    }
}
