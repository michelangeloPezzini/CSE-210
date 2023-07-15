using System;

public abstract class Task
{
    private static int lastTaskId = 0;

    public int TaskId { get; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Deadline { get; set; }
    public TaskStatus Status { get; set; }
    public int Progress { get; set; }

    public Task(string title, string description, DateTime deadline)
    {
        TaskId = ++lastTaskId;
        Title = title;
        Description = description;
        Deadline = deadline;
        Status = TaskStatus.NotStarted;
        Progress = 0;
    }

    public abstract void UpdateStatus();

    public virtual void UpdateProgress(int progress)
    {
        Progress = progress;
        Console.WriteLine($"Task {TaskId} progress updated to {progress}%.");
    }

    public override string ToString()
    {
        return $"Task {TaskId}: {Title} - {Description} | Deadline: {Deadline} | Status: {Status} | Progress: {Progress}%";
    }
}
