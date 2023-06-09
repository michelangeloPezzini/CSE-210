using System;
using System.Collections.Generic;
using System.Threading;

abstract class MindfulnessActivity
{
  protected string name;
  protected string description;
  public int duration;

  public abstract void Run();

  protected void ShowStartingMessage()
  {
    Console.WriteLine($"Starting {name} activity");
    Console.WriteLine(description);
    Console.WriteLine($"Duration: {duration} seconds");
    Console.WriteLine("Get ready to begin...");
    Pause(3);
  }

  protected void ShowFinishingMessage()
  {
    Console.WriteLine($"Good job! You have completed the {name} activity.");
    Console.WriteLine($"Duration: {duration} seconds");
    Pause(3);
  }

  protected void Pause(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.Write($"{i} ");
      Thread.Sleep(1000);
    }
    Console.WriteLine();
  }

  protected void ShowSpinner(int seconds)
  {
    for (int i = 0; i < seconds; i++)
    {
      Console.Write("/");
      Thread.Sleep(250);
      Console.Write("\b-");
      Thread.Sleep(250);
      Console.Write("\b\\");
      Thread.Sleep(250);
      Console.Write("\b|");
      Thread.Sleep(250);
    }
  }
}
