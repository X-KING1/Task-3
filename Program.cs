using System;

class Program
{
    static void Main(string[] args)
    {
        // Task 1: Operators
        Console.WriteLine("Task 1: Operators");
        Operators op = new Operators();
        op.Add(8, 4);
        op.Subtract(8, 4);
        op.Multiply(8, 4);
        op.Divide(8, 4);
        op.OddEvenFinder(5);
        op.OddEvenFinder(10);
        Console.WriteLine();

        // Task 2: Null Operations
        Console.WriteLine("Task 2: Null Operations");
        NullOperations nOps = new NullOperations();
        nOps.PerformNullChecks();
        Console.WriteLine();

        // Task 3: Age Check
        Console.WriteLine("Task 3: Age Check");
        AgeCheck ageCheck = new AgeCheck();
        ageCheck.CheckAge();
        Console.WriteLine();

        // Task 4: Day of the Week
        Console.WriteLine("Task 4: Day of the Week");
        DayOfWeekChecker dayCheck = new DayOfWeekChecker();
        dayCheck.PrintDay();
        Console.WriteLine();

        // Task 5: Loops
        Console.WriteLine("Task 5: Loops Tasks");
        LoopsTasks loops = new LoopsTasks();
        loops.SumToN();
        Console.WriteLine();
        loops.WhileLoopNumbers();
        Console.WriteLine();
        loops.ArraySum();
        Console.WriteLine();

        // Task 6: Try-Catch-Finally
        Console.WriteLine("Task 6: Try-Catch-Finally");
        TryCatchTasks tryCatch = new TryCatchTasks();
        tryCatch.NumberConversion();
        Console.WriteLine();
        tryCatch.CheckPassword();
        Console.WriteLine();
    }
}

