using System;

class Program
{
  static void Main()
  {
    string mytext = "Ola tudo bem com você?";
    string[] arrayText = mytext.Split(" ");

    foreach (string word in arrayText)
    {
      Console.WriteLine(word);
    }
  }
}
