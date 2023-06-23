public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value)
    {
    }

    public override void Complete()
    {
        Console.WriteLine($"Goal '{Name}' recorded! You gained {Value} points.");
    }
}
