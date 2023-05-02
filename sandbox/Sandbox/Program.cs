using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Type a color:");
    string color = Console.ReadLine();
    Console.WriteLine(color);

    if (color == "blue")
    {
      Console.WriteLine("Beautiful color");
    }

    string school = "BYU-Idaho";
    Console.WriteLine($"I am studying at {school}.");
  }

}