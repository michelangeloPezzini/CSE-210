using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Type your first name? ");
    string first_name = Console.ReadLine();
    Console.Write("Type your last name? ");
    string last_name = Console.ReadLine();
    Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");

    Console.Write("What is your grade percentage? ");
    string answer = Console.ReadLine();
    int percent = int.Parse(answer);

    string letter = "";

    if (percent >= 90)
    {
      letter = "A";
    }
    else if (percent >= 80)
    {
      letter = "B";
    }
    else if (percent >= 70)
    {
      letter = "C";
    }
    else if (percent >= 60)
    {
      letter = "D";
    }
    else
    {
      letter = "F";
    }

    Console.WriteLine($"Your grade is: {letter}");

    if (percent >= 70)
    {
      Console.WriteLine("You passed!");
    }
    else
    {
      Console.WriteLine("Better luck next time!");
    }

    //switch
    Console.Write("Digite uma cor? ");
    string cor = Console.ReadLine();

    switch (cor)
    {
      case "azul":
        Console.WriteLine("Sua cor é azul");
        break;
      case "amarelo":
        Console.WriteLine("Sua cor é Amarelo");
        break;
      case "verde":
        Console.WriteLine("Sua cor é verde");
        break;
      default:
        Console.WriteLine("A cor não foi encontrada");
        break;
    }

    //tipos de valores em c#
    const string lastName = "Pezzini"; 
    var name = "Mike";
    int birthday = 26;
    string month = "December";
    float miliseconds = 231.2f;
    bool black_hair = true;


    //inputs e outputs
    Console.Write("Qual é o novo Horario? ");
    var hour = Console.ReadLine();
    Console.WriteLine($"Seu novo horario é às {hour}");


    //operadores aritmeticos
    int soma = 20 + 30;
    int mult = 14 * 5;
    float div = 5.0f / 2;
    Console.WriteLine(soma);
    Console.WriteLine(mult);
    Console.WriteLine(div);

    //Condicionais // (&& = and) // (|| = or)
    Console.Write("Qual é a sua idade? ");
    int idade = int.Parse(Console.ReadLine());
    if (idade >= 18 && idade < 65)
    {
      Console.WriteLine($"Você tem {idade} anos e é maior de idade");
    }
    else if (idade >= 65)
    {
      Console.WriteLine($"Você tem {idade} anos e é já ganha um ingresso grátis");
    }
    else
    {
      Console.WriteLine($"Você tem {idade} anos e é menor de idade");
    }


    //funções

    static void ExibirMSG()
    {
      Console.WriteLine("Olá");
      Console.WriteLine("Olá");
      Console.WriteLine("Olá");

    }

    static int Somar(int a, int b, int c)
    {
      int resultadoFinal = a + b + c;
      return resultadoFinal;
    }

    int novaSoma = Somar(1, 2, 3);
    Console.WriteLine(novaSoma);
    ExibirMSG();

    //exemplo de array
    string[] products = new string[3]{
      "Doritos",
      "Coca",
      "Oreo"
    };

    int[] numbers = { 1, 2, 3, 4, 5, 6 };

    Console.WriteLine(products[1]);
    Console.ReadLine();
  }



}