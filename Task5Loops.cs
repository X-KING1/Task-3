using System;

public class LoopsTasks
{
    public void SumToN()
    {
        Console.Write("Enter a number N: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
            sum += i;
        Console.WriteLine("Sum from 1 to " + n + " is: " + sum);
    }

    public void WhileLoopNumbers()
    {
        int i = 1;
        while (i <= 20)
        {
            if (i % 4 == 0) { i++; continue; }
            if (i == 15) break;
            Console.WriteLine(i);
            i++;
        }
    }

    public void ArraySum()
    {
        int[] numbers = { 2, 4, 6, 8, 10 };
        int sum = 0;
        foreach (int x in numbers)
            sum += x;
        Console.WriteLine("Sum of array elements: " + sum);
    }
}

