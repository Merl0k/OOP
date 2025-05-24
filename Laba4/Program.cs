/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int age = 25;
        double weight = 72.5;
        char grade = 'A';
        bool isStudent = true;
        string name = "Олександр";

        Console.WriteLine("Вік: " + age);
        Console.WriteLine("Вага: " + weight);
        Console.WriteLine("Оцінка: " + grade);
        Console.WriteLine("Студент: " + isStudent);
        Console.WriteLine("Ім'я: " + name);
    }
}

*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть число (double): ");
        string input = Console.ReadLine();
         
        double doubleNumber = Convert.ToDouble(input);
        int intNumber = (int)doubleNumber;
        string stringNumber = intNumber.ToString();

        Console.WriteLine("Введене число (double): " + doubleNumber);
        Console.WriteLine("Після перетворення у int: " + intNumber);
        Console.WriteLine("Після перетворення у string: " + stringNumber);
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть ваше ім'я: ");
        string name = Console.ReadLine();

        Console.Write("Введіть ваш вік: ");
        string ageInput = Console.ReadLine();
        int age = Convert.ToInt32(ageInput);

        Console.WriteLine();
        Console.WriteLine("Привіт, " + name + "! Твій вік: " + age + " років.");
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть відстань (км): ");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть час (год): ");
        double time = Convert.ToDouble(Console.ReadLine());

        double speed = distance / time;

        Console.WriteLine("Середня швидкість: " + speed + " км/год");
    }
}
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть речення: ");
        string sentence = Console.ReadLine();

        int length = sentence.Length;

        string upper = sentence.ToUpper();

        string replaced = sentence.Replace(' ', '_');

        string firstFive = sentence.Length >= 5 ? sentence.Substring(0, 5) : sentence;

        Console.WriteLine("Довжина: " + length + " символів");
        Console.WriteLine("Верхній регістр: " + upper);
        Console.WriteLine("Замінені пробіли: " + replaced);
        Console.WriteLine("Перші 5 символів: " + firstFive);
    }
}
