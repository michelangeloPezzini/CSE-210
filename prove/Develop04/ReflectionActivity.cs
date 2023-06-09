using System;
using System.Collections.Generic;
using System.Threading;

class ReflectionActivity : MindfulnessActivity
{
  private static Random random = new Random();
  private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

  private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

  public ReflectionActivity()
  {
    name = "Reflection";
    description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
  }

  public override void Run()
  {
    ShowStartingMessage();

    int remainingSeconds = duration - 3;
    int promptIndex = random.Next(prompts.Count);

    Console.WriteLine(prompts[promptIndex]);
    Pause(3);

    foreach (string question in questions)
    {
      Console.WriteLine(question);
      ShowSpinner(3);
      Console.WriteLine();
      Pause(3);
    }

    while (remainingSeconds > 0)
    {
      Console.WriteLine(prompts[promptIndex]);
      Pause(3);
      remainingSeconds -= 2;

      foreach (string question in questions)
      {
        Console.WriteLine(question);
        ShowSpinner(3);
        Console.WriteLine();
        Pause(3);

        remainingSeconds -= 2;
        if (remainingSeconds <= 0)
          break;
      }

      promptIndex = (promptIndex + 1) % prompts.Count;
    }

    ShowFinishingMessage();
  }
}
