using System;
using System.Collections.Generic;

class Scripture
{
  //readonly is the same of const in javascript
  private readonly string reference;
  private readonly List<string> words;
  private readonly List<int> hiddenWordIndexes;
  private readonly Random random;

  public Scripture(string reference, string text)
  {
    this.reference = reference;

    //will be add word by word through the method ParseText in the words List
    words = new List<string>();
    //create a new instance of a list to store the index values
    hiddenWordIndexes = new List<int>();
    //will be select a random number in this variable because after this number will be used to choose a a word with this random number
    random = new Random();
    //call the method to fill the list with words of the verse
    ParseText(text);
  }

  public bool WordsLeftToHide()
  {
    //verify if still remaining words to hide
    return hiddenWordIndexes.Count < words.Count + 1;
  }

  public void ClearConsole()
  {
    // clear the console
    Console.Clear();
  }

  public void Display()
  {
    // show the reference of the verse
    Console.WriteLine(reference);
    Console.WriteLine();

    //words.Count = words.length
    for (int i = 0; i < words.Count; i++)
    {
      //determines whether the word at index i should be hidden or not.
      if (hiddenWordIndexes.Contains(i))
      {
        //it displays a sequence of underscores (_) with the same length as the word. 
        Console.Write(new string('_', words[i].Length));
      }
      else
      {
        //If the word at index i is not supposed to be hidden, it displays the word normally.
        Console.Write(words[i]);
      }

      Console.Write(" ");
    }

    Console.WriteLine();
  }

  public void HideRandomWord()
  {
    //select a random index to hide a word
    int wordIndex = GetRandomWordIndex();
    //add the index into the list of hiden words
    hiddenWordIndexes.Add(wordIndex);
  }

  //method create to split the words and after add them into the array wordSeparated
  private void ParseText(string text)
  {
    string[] wordStrings = text.Split(' ');

    foreach (string wordSeparated in wordStrings)
    {
      //add each wordSeparated into the word list
      words.Add(wordSeparated);
    }
  }

  private int GetRandomWordIndex()
  {
    List<int> availableIndexes = new List<int>();

    for (int i = 0; i < words.Count; i++)
    {
      if (!hiddenWordIndexes.Contains(i))
      {
        availableIndexes.Add(i); // Adiciona os índices das palavras visíveis à lista de índices disponíveis
      }
    }

    if (availableIndexes.Count == 0)
    {
      return -1; // Retorna -1 se não houver palavras disponíveis para ocultar
    }

    int randomIndex = random.Next(0, availableIndexes.Count); // Gera um índice aleatório da lista de índices disponíveis
    return availableIndexes[randomIndex]; // Retorna o índice aleatório
  }
}
