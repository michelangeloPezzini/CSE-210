using System;

class BreathingActivity : MindfulnessActivity
{
  public BreathingActivity()
  {
    name = "Breathing";
    description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
  }

  public override void Run()
  {
    ShowStartingMessage();

    Console.WriteLine("Breathe in...");
    Pause(3);
    Console.WriteLine("Breathe out...");
    Pause(3);

    int remainingSeconds = duration - 4;
    int count = remainingSeconds / 2;

    for (int i = 0; i < count; i++)
    {
      Console.WriteLine("Breathe in...");
      Pause(3);
      Console.WriteLine("Breathe out...");
      Pause(3);
      remainingSeconds -= 4;
    }

    if (remainingSeconds > 0)
    {
      Console.WriteLine("Breathe in...");
      Pause(remainingSeconds);
    }

    ShowFinishingMessage();
  }
}
