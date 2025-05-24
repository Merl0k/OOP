/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Результат: Число парне.");
        }
        else
        {
            Console.WriteLine("Результат: Число непарне.");
        }
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть вашу оцінку: ");
        int score = Convert.ToInt32(Console.ReadLine());

        if (score >= 90 && score <= 100)
        {
            Console.WriteLine("Результат: Ваша оцінка: A");
        }
        else if (score >= 75 && score <= 89)
        {
            Console.WriteLine("Результат: Ваша оцінка: B");
        }
        else if (score >= 60 && score <= 74)
        {
            Console.WriteLine("Результат: Ваша оцінка: C");
        }
        else if (score < 60 && score >= 0)
        {
            Console.WriteLine("Результат: Ваша оцінка: F");
        }
        else
        {
            Console.WriteLine("Помилка: Введено недопустиму оцінку.");
        }
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть число (1-7): ");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        switch (dayNumber)
        {
            case 1:
                Console.WriteLine("Результат: Понеділок");
                break;
            case 2:
                Console.WriteLine("Результат: Вівторок");
                break;
            case 3:
                Console.WriteLine("Результат: Середа");
                break;
            case 4:
                Console.WriteLine("Результат: Четвер");
                break;
            case 5:
                Console.WriteLine("Результат: П’ятниця");
                break;
            case 6:
                Console.WriteLine("Результат: Субота");
                break;
            case 7:
                Console.WriteLine("Результат: Неділя");
                break;
            default:
                Console.WriteLine("Помилка: Введіть число від 1 до 7.");
                break;
        }
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть марку авто: ");
        string brand = Console.ReadLine();

        switch (brand.ToLower())
        {
            case "toyota":
                Console.WriteLine("Результат: Японія");
                break;
            case "bmw":
                Console.WriteLine("Результат: Німеччина");
                break;
            case "tesla":
                Console.WriteLine("Результат: США");
                break;
            default:
                Console.WriteLine("Результат: Невідома марка або країна.");
                break;
        }
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть температуру: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        string result = temperature >= 0 ? "Погода тепла." : "Погода холодна.";

        Console.WriteLine("Результат: " + result);
    }
}
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Введіть перше число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;

            Console.WriteLine("Результат: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Результат: Помилка: поділ на нуль!");
        }
    }
}
