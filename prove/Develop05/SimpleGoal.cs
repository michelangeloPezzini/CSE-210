public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name, value)
    {
    }

    public override void Complete()
    {
        IsCompleted = true;
        Console.WriteLine($"Goal '{Name}' completed! You gained {Value} points.");
    }
}
