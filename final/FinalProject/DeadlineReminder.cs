using System;

class DeadlineReminder
{
    public void SendReminder(User user, Task task)
    {
        Console.WriteLine($"Reminder: Task {task.TaskId} - {task.Title} is approaching its deadline.");
    }
}
