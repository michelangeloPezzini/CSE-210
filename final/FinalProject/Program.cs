using System;

class Program
{
    static void Main(string[] args)
    {
        UserInterface userInterface = new UserInterface();
        User user = new User("JohnDoe", "password", "john.doe@example.com");
        user.Authenticate();

        TaskManager taskManager = new TaskList();
        UserInterfaceTaskManagerAdapter taskManagerAdapter = new UserInterfaceTaskManagerAdapter(userInterface, taskManager);

        int choice;
        do
        {
            userInterface.DisplayMenu();
            choice = userInterface.GetUserChoice();

            switch (choice)
            {
                case 1:
                    string title = userInterface.GetUserInput("Enter task title");
                    string description = userInterface.GetUserInput("Enter task description");
                    DateTime deadline = DateTime.Parse(userInterface.GetUserInput("Enter task deadline (yyyy-mm-dd)"));
                    taskManagerAdapter.CreateTask(title, description, deadline);
                    break;
                case 2:
                    int taskId = int.Parse(userInterface.GetUserInput("Enter task ID"));
                    string statusString = userInterface.GetUserInput("Enter task status (NotStarted/InProgress/Completed)");
                    TaskStatus status = (TaskStatus)Enum.Parse(typeof(TaskStatus), statusString, true);
                    taskManagerAdapter.UpdateTaskStatus(taskId, status);
                    break;
                case 3:
                    taskId = int.Parse(userInterface.GetUserInput("Enter task ID"));
                    int progress = int.Parse(userInterface.GetUserInput("Enter task progress"));
                    taskManagerAdapter.UpdateTaskProgress(taskId, progress);
                    break;
                case 4:
                    taskId = int.Parse(userInterface.GetUserInput("Enter task ID"));
                    taskManagerAdapter.DeleteTask(taskId);
                    break;
                case 5:
                    taskManagerAdapter.PrintAllTasks();
                    break;
                case 0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            Console.WriteLine();
        }
        while (choice != 0);

        Console.ReadLine();
    }
}
