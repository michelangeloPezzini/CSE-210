public class QuestTracker
{
    private List<Goal> goals;
    public int Score { get; private set; }

    public QuestTracker()
    {
        goals = new List<Goal>();
        Score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
        Console.WriteLine($"New goal '{goal.Name}' added!");
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            Goal goal = goals[goalIndex];
            goal.Complete();
            if (!goal.IsCompleted)
            {
                Score += goal.Value;
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index!");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your current score: {Score} points");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Current Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            string status = goal.IsCompleted ? "[X]" : "[ ]";
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"{i + 1}. {status} {goal.Name} (Completed {checklistGoal.TargetCount}/{checklistGoal.TargetCount} times)");
            }
            else
            {
                Console.WriteLine($"{i + 1}. {status} {goal.Name}");
            }
        }
    }

    public void SaveGoals(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Goal goal in goals)
                {
                    writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Value},{goal.IsCompleted}");
                }
            }

            Console.WriteLine("Goals saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    public void LoadGoals(string fileName)
    {
        try
        {
            List<Goal> loadedGoals = new List<Goal>();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    string goalType = parts[0];
                    string name = parts[1];
                    int value = int.Parse(parts[2]);
                    bool isCompleted = bool.Parse(parts[3]);

                    Goal goal;

                    switch (goalType)
                    {
                        case "SimpleGoal":
                            goal = new SimpleGoal(name, value);
                            break;
                        case "EternalGoal":
                            goal = new EternalGoal(name, value);
                            break;
                        case "ChecklistGoal":
                            int targetCount = int.Parse(parts[4]);
                            goal = new ChecklistGoal(name, value, targetCount);
                            break;
                        default:
                            throw new Exception($"Unknown goal type: {goalType}");
                    }

                    goal.IsCompleted = isCompleted;
                    loadedGoals.Add(goal);
                }
            }

            goals = loadedGoals;
            Console.WriteLine("Goals loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}
