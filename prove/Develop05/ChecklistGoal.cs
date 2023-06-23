public class ChecklistGoal : Goal
{
    public int TargetCount { get; private set; }
    private int completionCount;

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        TargetCount = targetCount;
        completionCount = 0;
    }

    public override void Complete()
    {
        completionCount++;
        Console.WriteLine($"Goal '{Name}' completed {completionCount}/{TargetCount} times.");

        if (completionCount == TargetCount)
        {
            IsCompleted = true;
            Console.WriteLine($"Congratulations! You achieved the goal '{Name}' and earned a bonus of {Value} points.");
        }
        else
        {
            Console.WriteLine($"Keep going! You gained {Value} points for completing the goal.");
        }
    }
}
