/*
using System;

struct Point
{
    public double X { get; }
    public double Y { get; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double DistanceTo(Point other)
    {
        double dx = X - other.X;
        double dy = Y - other.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}
class Program
{
    static void Main()
    {
        Point p1 = new Point(3, 4);
        Point p2 = new Point(0, 0);

        Console.WriteLine(p1.DistanceTo(p2)); 
    }
}
*/
using System;

class Car
{
    private string Brand;
    private string Model;
    private int Year;
    private string Color;
    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
        Year = 0;        
        Color = "Невідомий";
    }
    public Car(string brand, string model, int year)
        : this(brand, model)
    {
        Year = year;
    }
    public Car(string brand, string model, int year, string color)
        : this(brand, model, year)
    {
        Color = color;
    }
    public void ShowInfo()
    {
        Console.WriteLine("Автомобіль:");
        Console.WriteLine($"Марка: {Brand}");
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Рік випуску: {(Year == 0 ? "Невідомий" : Year.ToString())}");
        Console.WriteLine($"Колір: {Color}");
        Console.WriteLine();
    }
}
class Program
{
    static void Main()
    {
        Car car1 = new Car("Toyota", "Corolla");
        Car car2 = new Car("Honda", "Civic", 2018);
        Car car3 = new Car("BMW", "X5", 2020, "Чорний");

        car1.ShowInfo();
        car2.ShowInfo();
        car3.ShowInfo();
    }
}
