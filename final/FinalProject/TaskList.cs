using System;
using System.Collections.Generic;

class TaskList : TaskManager
{
    public override void CreateTask(string title, string description, DateTime deadline)
    {
        Task newTask = new TaskListTask(title, description, deadline);
        tasks.Add(newTask);
    }

    public override void UpdateTaskStatus(int taskId, TaskStatus status)
    {
        TaskListTask task = GetTaskById(taskId) as TaskListTask;
        if (task != null)
        {
            task.Status = status;
            Console.WriteLine($"Task {taskId} status updated to {status}.");
        }
        else
        {
            Console.WriteLine($"Task {taskId} not found.");
        }
    }

    public override void UpdateTaskProgress(int taskId, int progress)
    {
        TaskListTask task = GetTaskById(taskId) as TaskListTask;
        if (task != null)
        {
            task.UpdateProgress(progress);
        }
        else
        {
            Console.WriteLine($"Task {taskId} not found.");
        }
    }
}
