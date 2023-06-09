using System;

class Program
{
  static void Main(string[] args)
  {
    while (true)
    {
      Console.WriteLine("Mindfulness App");
      Console.WriteLine("1. Breathing Activity");
      Console.WriteLine("2. Reflection Activity");
      Console.WriteLine("3. Listing Activity");
      Console.WriteLine("4. Exit");
      Console.Write("Select an activity: ");

      string choice = Console.ReadLine(); // Read user input and store it in the 'choice' variable
      Console.WriteLine();
      Console.WriteLine();

      MindfulnessActivity activity;

      switch (choice) // Evaluate the value of 'choice'
      {
        case "1":
          // Create a new instance of BreathingActivity and assign it to 'activity'
          activity = new BreathingActivity();
          break;
        case "2":
          // Create a new instance of ReflectionActivity and assign it to 'activity'
          activity = new ReflectionActivity();
          break;
        case "3":
          // Create a new instance of ListingActivity and assign it to 'activity'
          activity = new ListingActivity();
          break;
        case "4":
          return; // Exit the program
        default: // If 'choice' is none of the above
          Console.WriteLine("Invalid choice. Please try again."); // Display "Invalid choice. Please try again."
          Console.WriteLine();
          continue; // Go back to the beginning of the loop
      }

      Console.Write("Enter the duration (in seconds): ");
      if (!int.TryParse(Console.ReadLine(), out int duration) || duration <= 0)
      {
        Console.WriteLine("Invalid duration. Please try again.");
        Console.WriteLine();
        continue;
      }

      // Assign the 'duration' value to the 'duration' property of 'activity'
      activity.duration = duration;
      Console.WriteLine();

      // Call the Run method of 'activity'
      activity.Run();

      Console.WriteLine();
      // Display "Press any key to continue..."
      Console.WriteLine("Press any key to continue...");
      Console.ReadKey();
      Console.WriteLine();
    }
  }
}
