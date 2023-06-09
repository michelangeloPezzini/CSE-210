using System;
using System.Collections.Generic;

class ListingActivity : MindfulnessActivity
{
  private static Random random = new Random();
  private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

  public ListingActivity()
  {
    name = "Listing";
    description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
  }

  public override void Run()
  {
    ShowStartingMessage();

    int itemCounter = 0;
    int remainingSeconds = duration - 3;
    int promptIndex = random.Next(prompts.Count);

    Console.WriteLine(prompts[promptIndex]);
    Pause(3);

    DateTime endTime = DateTime.Now.AddSeconds(remainingSeconds);
    while (DateTime.Now < endTime)
    {
      string item = Console.ReadLine();
      if (!string.IsNullOrWhiteSpace(item))
      {
        itemCounter++;
      }
    }

    Console.WriteLine($"Number of items listed: {itemCounter}");

    ShowFinishingMessage();
  }
}
