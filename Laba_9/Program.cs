﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 8, 5, 2, 9, 1, 5, 6 };
        int swapCount = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - 1 - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;

                    swapCount++; 
                }
            }
        }

        Console.WriteLine($"Кількість перестановок: {swapCount}");
        Console.Write("Після сортування: [");
        Console.Write(string.Join(", ", numbers));
        Console.WriteLine("]");
    }
}
    