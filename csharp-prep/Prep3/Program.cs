using System;
using System.Collections.Generic;
using System.IO;

class Program
{
  static void Main(string[] args)
  {
    //First of all, I always build a new instance of the class
    /*     Person p1 = new Person();
        p1._firstName = "Mike";
        p1._lastName = "Pezzini";
        p1._age = 25;

        Person p2 = new Person();
        p2._firstName = "Gabriela";
        p2._lastName = "Cachapuz";
        p2._age = 24;

        Person p3 = new Person();
        p3._firstName = "Nezuko";
        p3._lastName = "Kamado";
        p3._age = 18;

        List<Person> people = new List<Person>();

        people.Add(p1);
        people.Add(p2);
        people.Add(p3);

        SaveToFile(people); */

    List<Person> newPeople = ReadFromFile();
    foreach (Person p in newPeople)
    {
      Console.WriteLine(p._firstName);
    }

  }

  public static void SaveToFile(List<Person> people)
  {

    Console.WriteLine("Saving to file...");
    string filename = "people.txt";
    using (StreamWriter outputFile = new StreamWriter(filename))
    {
      foreach (Person p in people)
      {
        outputFile.WriteLine($"{p._firstName} {p._lastName} | {p._age}");
      }
    }

  }

  public static List<Person> ReadFromFile()
  {
    Console.WriteLine("Reading file...");
    List<Person> people = new List<Person>();
    string filename = "people.txt";

    string[] lines = System.IO.File.ReadAllLines(filename);
    foreach (string line in lines)
    {
      string[] parts = line.Split("~~");

      Person newPerson = new Person();
      newPerson._firstName = parts[0];
      newPerson._lastName = parts[1];
      newPerson._age = int.Parse(parts[2]);

      people.Add(newPerson);
    }

    return people;
  }

}