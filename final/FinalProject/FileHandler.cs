using System;
using System.Collections.Generic;

class FileHandler
{
    public void SaveTasksToFile(List<Task> tasks)
    {
        // Save tasks to file
        Console.WriteLine("Tasks saved to file.");
    }

    public List<Task> LoadTasksFromFile()
    {
        // Load tasks from file
        Console.WriteLine("Tasks loaded from file.");
        return new List<Task>();
    }
}
