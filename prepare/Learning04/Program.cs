using System;

class Program
{
  static void Main(string[] args)
  {
    Assignment student1 = new Assignment();
    student1.SetStudentName("Mike");
    student1.SetTopic("Fractions");
    Console.WriteLine(student1.GetSummary());

    MathAssignment student2 = new MathAssignment();
    student2.SetStudentName("Michelangelo Pezzini");
    student2.SetTopic("Multiplication");
    student2.SetTextbookSection("4.2");
    student2.SetProblems("1-10");
    Console.WriteLine(student2.GetHomeworkList());

    WritingAssignment student3 = new WritingAssignment();
    student3.SetStudentName("Gabriela Cachapuz");
    student3.SetTopic("2° War");
    student3.SetTitle("The second war and the mistery of a soldier");
    Console.WriteLine(student3.GetWritingInformation());

  }
}