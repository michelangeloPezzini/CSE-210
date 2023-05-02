using System;

class Program
{
  static void Main(string[] args)
  {

    //Sum the numbers of a list

    List<int> numbers = new List<int>();

    int user_choice = -1;

    while (user_choice != 0)
    {
      Console.Write("Type a number: ");
      user_choice = int.Parse(Console.ReadLine());

      if (user_choice != 0)
      {
        numbers.Add(user_choice);
      }
    }

    int total = 0;
    int count = 0;
    float average = 0;
    int largest = 0;

    for (int i = 0; i < numbers.Count; i++)
    {
      total += numbers[i];
      count += 1;

      if (numbers[i] > largest)
      {
        largest = numbers[i];
      }
    }

    average = total / count;

    Console.WriteLine($"The sum is: {total}");
    Console.WriteLine($"The average is: {average}");
    Console.WriteLine($"The largest number is: {largest}");
    Console.ReadLine();
  }
}