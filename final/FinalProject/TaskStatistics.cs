using System;
using System.Collections.Generic;

class TaskStatistics
{
    private List<Task> tasks;

    public TaskStatistics(List<Task> tasks)
    {
        this.tasks = tasks;
    }

    public int GetCompletedTaskCount()
    {
        int count = 0;
        foreach (Task task in tasks)
        {
            if (task.Status == TaskStatus.Completed)
            {
                count++;
            }
        }
        return count;
    }

    public double GetAverageProgress()
    {
        double totalProgress = 0;
        foreach (Task task in tasks)
        {
            totalProgress += task.Progress;
        }
        return tasks.Count > 0 ? totalProgress / tasks.Count : 0;
    }
}
