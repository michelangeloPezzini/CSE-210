using System;

class UserInterface
{
    public void DisplayMenu()
    {
        Console.WriteLine("1. Create Task");
        Console.WriteLine("2. Update Task Status");
        Console.WriteLine("3. Update Task Progress");
        Console.WriteLine("4. Delete Task");
        Console.WriteLine("5. Print All Tasks");
        Console.WriteLine("0. Exit");
        Console.WriteLine();
    }

    public int GetUserChoice()
    {
        Console.Write("Enter your choice: ");
        return int.Parse(Console.ReadLine());
    }

    public string GetUserInput(string message)
    {
        Console.Write(message + ": ");
        return Console.ReadLine();
    }
}
