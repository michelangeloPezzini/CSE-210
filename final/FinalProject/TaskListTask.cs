using System;

public class TaskListTask : Task
{
    public TaskListTask(string title, string description, DateTime deadline)
        : base(title, description, deadline)
    {
    }

    public override void UpdateStatus()
    {
        if (Progress == 100)
        {
            Status = TaskStatus.Completed;
        }
        else if (Progress > 0)
        {
            Status = TaskStatus.InProgress;
        }
        else
        {
            Status = TaskStatus.NotStarted;
        }
        Console.WriteLine($"Task {TaskId} status updated to {Status}.");
    }
}
