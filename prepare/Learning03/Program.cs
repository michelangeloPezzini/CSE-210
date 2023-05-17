using System;

class Program
{
  static void Main(string[] args)
  {
    Fraction f1 = new Fraction();
    Console.WriteLine(f1.GetFractionString());
    Console.WriteLine(f1.GetDecimalValue());
    Fraction f2 = new Fraction(10);
    Console.WriteLine(f2.GetFractionString());
    Console.WriteLine(f2.GetDecimalValue());
    Fraction f3 = new Fraction(15, 5);
    Console.WriteLine(f3.GetFractionString());
    Console.WriteLine(f3.GetDecimalValue());
  }
}