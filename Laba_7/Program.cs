/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Парні числа від 2 до 20:");

        for (int i = 2; i <= 20; i += 2)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine(); 
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int number;

        Console.WriteLine("Вводьте числа (введення 0 завершить цикл):");

        while (true)
        {
            Console.Write("Введіть число: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
                break;

            sum += number;
        }

        Console.WriteLine("Сума чисел: " + sum);
    }
}
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        string correctPassword = "1234";
        string input;

        do
        {
            Console.Write("Введіть пароль: ");
            input = Console.ReadLine();

            if (input != correctPassword)
            {
                Console.WriteLine("Неправильний пароль!");
            }

        } while (input != correctPassword);

        Console.WriteLine("Доступ дозволено!");
    }
}

