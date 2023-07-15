using System;

class User
{
    private string username;
    private string password;
    private string email;

    public User(string username, string password, string email)
    {
        this.username = username;
        this.password = password;
        this.email = email;
    }

    public void Authenticate()
    {
        // Authentication logic
        Console.WriteLine($"User {username} authenticated successfully.");
    }

    public void ManageTasks(TaskManager taskManager)
    {
        taskManager.CreateTask("Finish report", "Write the final report for the project", new DateTime(2023, 7, 10));
        taskManager.CreateTask("Prepare presentation", "Create slides for the project presentation", new DateTime(2023, 7, 15));

        taskManager.PrintAllTasks();

        Console.WriteLine();

        taskManager.UpdateTaskStatus(1, TaskStatus.InProgress);
        taskManager.UpdateTaskProgress(1, 50);

        Console.WriteLine();

        taskManager.UpdateTaskStatus(2, TaskStatus.Completed);
        taskManager.UpdateTaskProgress(2, 100);

        Console.WriteLine();

        taskManager.PrintAllTasks();

        Console.WriteLine();

        taskManager.DeleteTask(1);
        taskManager.DeleteTask(3);

        Console.WriteLine();

        taskManager.PrintAllTasks();
    }
}
