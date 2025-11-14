using System;

public class TryCatchTasks
{
    public void NumberConversion()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        try
        {
            int num = Convert.ToInt32(input);
            Console.WriteLine("You entered: " + num);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number format");
        }
        finally
        {
            Console.WriteLine("Program Executed");
        }
    }

    public void CheckPassword()
    {
        Console.Write("Enter a password: ");
        string password = Console.ReadLine();
        try
        {
            if (password.Length < 6)
                throw new Exception("Password must be at least 6 characters.");
            else
                Console.WriteLine("Password satisfied the requirement");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

