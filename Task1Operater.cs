using System;

public class Operators
{
    public void Add(int a, int b) => Console.WriteLine("Addition: " + (a + b));
    public void Subtract(int a, int b) => Console.WriteLine("Subtraction: " + (a - b));
    public void Multiply(int a, int b) => Console.WriteLine("Multiplication: " + (a * b));
    public void Divide(int a, int b) => Console.WriteLine("Division: " + (a / b));

    public void OddEvenFinder(int num)
    {
        if (num % 2 == 0) Console.WriteLine(num + " is Even");
        else Console.WriteLine(num + " is Odd");
    }
}

