using System;

class Program
{
  static void Main(string[] args)
  {
    Journal myJournal = new Journal();
    bool exitProgram = false; // inicial value to exit and finish the program

    while (!exitProgram) //while loop will finish when exit program became true
    {
      Console.WriteLine("Please choose an option:");
      Console.WriteLine("1. Write a new entry");
      Console.WriteLine("2. Display the journal");
      Console.WriteLine("3. Save the journal to a file");
      Console.WriteLine("4. Load the journal from a file");
      Console.WriteLine("5. Exit");

      int choice = int.Parse(Console.ReadLine());

      switch (choice)
      {
        // call the WriteNewEntry method of the Journal object
        case 1:
          myJournal.WriteNewEntry();
          break;
        // call the DisplayJournal method of the Journal object
        case 2:
          myJournal.DisplayJournal();
          break;
        // ask the user for a filename and then call the SaveJournalToFile method of the Journal object with that filename
        case 3:
          Console.WriteLine("Please enter a filename:");
          string fileName = Console.ReadLine();
          myJournal.SaveJournalToFile(fileName);
          break;
        // ask the user for a filename and then call the LoadJournalFromFile method of the Journal object with that filename
        case 4:
          Console.WriteLine("Please enter a filename:");
          fileName = Console.ReadLine();
          myJournal.LoadJournalFromFile(fileName);
          break;
        // set exitProgram to true to exit the loop
        case 5:
          exitProgram = true;
          break;
        // display an error message
        default:
          Console.WriteLine("Invalid choice. Please try again.");
          break;

      }
    }
  }
}
