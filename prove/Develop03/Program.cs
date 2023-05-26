using System;
using System.Collections.Generic;

class Program
{
  static void Main()
  {
    // Create a new instance of the Scripture class with the reference and text
    //Class   var         constructor or method of the class
    Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

    while (scripture.WordsLeftToHide())
    {
      scripture.ClearConsole(); // clean the console
      Console.WriteLine("Memorize game!");
      Console.WriteLine();
      scripture.Display(); // display the verse on console
      Console.WriteLine();
      Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
      string input = Console.ReadLine(); // Read the input of the user

      if (input == "quit")
      {
        return; // Finish the program when the user type "quit"
      }

      scripture.HideRandomWord(); // hide a randon word of the verse
    }

    Console.WriteLine("All words in the scripture are hidden."); // Shows a message when all the words are hide
  }
}
