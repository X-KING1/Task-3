using System;

public class AgeCheck
{
    public void CheckAge()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 13)
            Console.WriteLine("Child");
        else if (age >= 13 && age <= 19)
            Console.WriteLine("Teenager");
        else
            Console.WriteLine("Adult");
    }
}

