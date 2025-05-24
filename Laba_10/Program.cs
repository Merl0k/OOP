using System;
using System.Collections.Generic;

class MortgageApplication
{
    public decimal LoanAmount { get; set; }
    public decimal AnnualInterestRate { get; set; }
    public int Years { get; set; }

    public MortgageApplication(decimal loanAmount, decimal annualInterestRate, int years)
    {
        LoanAmount = loanAmount;
        AnnualInterestRate = annualInterestRate;
        Years = years;
    }

    public decimal CalculateMonthlyPayment()
    {
        decimal P = LoanAmount;
        decimal r = AnnualInterestRate / 12 / 100;
        int n = Years * 12; 

        if (r == 0) 
        {
            return Math.Round(P / n, 2);
        }

        decimal numerator = r * (decimal)Math.Pow((double)(1 + r), n);
        decimal denominator = (decimal)Math.Pow((double)(1 + r), n) - 1;

        decimal M = P * numerator / denominator;

        return Math.Round(M, 2);
    }

    public override string ToString()
    {
        return $"Сума: {LoanAmount}, Відсоток (річн.): {AnnualInterestRate}%, Роки: {Years}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Queue<MortgageApplication> queue = new Queue<MortgageApplication>();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1 - Додати заявку");
            Console.WriteLine("2 - Обробити першу заявку");
            Console.WriteLine("3 - Подивитися першу заявку");
            Console.WriteLine("4 - Показати всі заявки");
            Console.WriteLine("0 - Вийти");
            Console.Write("Виберіть дію: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddApplication(queue);
                    break;

                case "2":
                    ProcessApplication(queue);
                    break;

                case "3":
                    PeekApplication(queue);
                    break;

                case "4":
                    ShowAllApplications(queue);
                    break;

                case "0":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Невірна команда, спробуйте ще раз.");
                    break;
            }
        }
    }

    static void AddApplication(Queue<MortgageApplication> queue)
    {
        Console.Write("Введіть суму кредиту: ");
        decimal loanAmount = decimal.Parse(Console.ReadLine());

        Console.Write("Введіть річну відсоткову ставку (%): ");
        decimal annualInterest = decimal.Parse(Console.ReadLine());

        Console.Write("Введіть термін кредиту (роки): ");
        int years = int.Parse(Console.ReadLine());

        MortgageApplication app = new MortgageApplication(loanAmount, annualInterest, years);
        queue.Enqueue(app);

        Console.WriteLine("Заявку додано до черги.");
    }

    static void ProcessApplication(Queue<MortgageApplication> queue)
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("Черга порожня.");
            return;
        }

        MortgageApplication app = queue.Dequeue();
        decimal payment = app.CalculateMonthlyPayment();
        Console.WriteLine($"Оброблено заявку: {app}");
        Console.WriteLine($"Щомісячний платіж: {payment} грн.");
    }

    static void PeekApplication(Queue<MortgageApplication> queue)
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("Черга порожня.");
            return;
        }

        MortgageApplication app = queue.Peek();
        Console.WriteLine($"Перша заявка в черзі: {app}");
    }

    static void ShowAllApplications(Queue<MortgageApplication> queue)
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("Черга порожня.");
            return;
        }

        Console.WriteLine("Всі заявки у черзі:");
        int i = 1;
        foreach (var app in queue)
        {
            Console.WriteLine($"{i}. {app}");
            i++;
        }
    }
}
