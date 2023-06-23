public class Program
{
    public static void Main(string[] args)
    {
        QuestTracker tracker = new QuestTracker();

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");

            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
                case "1":
                    CreateGoal(tracker);
                    break;
                case "2":
                    tracker.DisplayGoals();
                    break;
                case "3":
                    Console.Write("Enter the file name to save the goals: ");
                    string saveFileName = Console.ReadLine();
                    tracker.SaveGoals(saveFileName);
                    break;
                case "4":
                    Console.Write("Enter the file name to load the goals: ");
                    string loadFileName = Console.ReadLine();
                    tracker.LoadGoals(loadFileName);
                    break;
                case "5":
                    RecordEvent(tracker);
                    break;
                case "6":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static void CreateGoal(QuestTracker tracker)
    {
        Console.WriteLine("Choose a goal type:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");

        Console.Write("Enter your choice: ");
        string input = Console.ReadLine();
        Console.WriteLine();

        switch (input)
        {
            case "1":
                CreateSimpleGoal(tracker);
                break;
            case "2":
                CreateEternalGoal(tracker);
                break;
            case "3":
                CreateChecklistGoal(tracker);
                break;
            default:
                Console.WriteLine("Invalid choice! Please try again.");
                break;
        }
    }

    private static void CreateSimpleGoal(QuestTracker tracker)
    {
        Console.Write("Enter the name of the simple goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter the value for completing the goal: ");
        int value = Convert.ToInt32(Console.ReadLine());

        Goal simpleGoal = new SimpleGoal(name, value);
        tracker.AddGoal(simpleGoal);

        Console.WriteLine($"Simple goal '{name}' created!");
    }

    private static void CreateEternalGoal(QuestTracker tracker)
    {
        Console.Write("Enter the name of the eternal goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter the value for each recording of the goal: ");
        int value = Convert.ToInt32(Console.ReadLine());

        Goal eternalGoal = new EternalGoal(name, value);
        tracker.AddGoal(eternalGoal);

        Console.WriteLine($"Eternal goal '{name}' created!");
    }

    private static void CreateChecklistGoal(QuestTracker tracker)
    {
        Console.Write("Enter the name of the checklist goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter the value for each completion of the goal: ");
        int value = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the target count for completing the goal: ");
        int targetCount = Convert.ToInt32(Console.ReadLine());

        Goal checklistGoal = new ChecklistGoal(name, value, targetCount);
        tracker.AddGoal(checklistGoal);

        Console.WriteLine($"Checklist goal '{name}' created!");
    }

    private static void RecordEvent(QuestTracker tracker)
    {
        Console.WriteLine("Select a goal to record an event:");

        tracker.DisplayGoals();

        Console.Write("Enter the index of the goal: ");
        int goalIndex = Convert.ToInt32(Console.ReadLine()) - 1;

        tracker.RecordEvent(goalIndex);
    }
}
