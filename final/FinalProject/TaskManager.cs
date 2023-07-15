using System;
using System.Collections.Generic;

public abstract class TaskManager
{
    protected List<Task> tasks;

    public TaskManager()
    {
        tasks = new List<Task>();
    }

    public abstract void CreateTask(string title, string description, DateTime deadline);

    public abstract void UpdateTaskStatus(int taskId, TaskStatus status);

    public abstract void UpdateTaskProgress(int taskId, int progress);

    public void DeleteTask(int taskId)
    {
        Task task = GetTaskById(taskId);
        if (task != null)
        {
            tasks.Remove(task);
            Console.WriteLine($"Task {taskId} deleted.");
        }
        else
        {
            Console.WriteLine($"Task {taskId} not found.");
        }
    }

    public void PrintAllTasks()
    {
        foreach (Task task in tasks)
        {
            Console.WriteLine(task);
        }
    }

    protected Task GetTaskById(int taskId)
    {
        foreach (Task task in tasks)
        {
            if (task.TaskId == taskId)
            {
                return task;
            }
        }
        return null;
    }
}
