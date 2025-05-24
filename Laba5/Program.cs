/*
using System;

class Program
{
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(IsEven(8)); 
        Console.WriteLine(IsEven(7)); 
    }
}

*/
/*
using System;

class Program
{
    static int Sum(int a, int b)
    {
        return a + b;
    }
    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
    static double Sum(double a, double b)
    {
        return a + b;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Sum(5, 10));      // 15
        Console.WriteLine(Sum(2, 3, 4));    // 9
        Console.WriteLine(Sum(2.5, 3.1));   // 5.6
    }
}
*/
using System;

class Program
{
    static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    static void Main(string[] args)
    {
        int a = 5, b = 10;
        Console.WriteLine($"До виклику Swap: a = {a}, b = {b}");

        Swap(ref a, ref b);

        Console.WriteLine($"Після виклику Swap: a = {a}, b = {b}");
    }
}
