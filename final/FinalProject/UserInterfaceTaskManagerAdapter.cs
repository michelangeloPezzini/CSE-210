using System;

class UserInterfaceTaskManagerAdapter
{
    private UserInterface userInterface;
    private TaskManager taskManager;

    public UserInterfaceTaskManagerAdapter(UserInterface userInterface, TaskManager taskManager)
    {
        this.userInterface = userInterface;
        this.taskManager = taskManager;
    }

    public void CreateTask(string title, string description, DateTime deadline)
    {
        userInterface.GetUserInput("Press any key to create a task...");
        taskManager.CreateTask(title, description, deadline);
        Console.WriteLine("Task created successfully.");
    }

    public void UpdateTaskStatus(int taskId, TaskStatus status)
    {
        userInterface.GetUserInput("Press any key to update task status...");
        taskManager.UpdateTaskStatus(taskId, status);
    }

    public void UpdateTaskProgress(int taskId, int progress)
    {
        userInterface.GetUserInput("Press any key to update task progress...");
        taskManager.UpdateTaskProgress(taskId, progress);
    }

    public void DeleteTask(int taskId)
    {
        userInterface.GetUserInput("Press any key to delete a task...");
        taskManager.DeleteTask(taskId);
    }

    public void PrintAllTasks()
    {
        userInterface.GetUserInput("Press any key to print all tasks...");
        taskManager.PrintAllTasks();
    }
}
