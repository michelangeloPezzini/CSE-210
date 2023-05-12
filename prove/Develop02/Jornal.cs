class Journal
{
  // Declare a list to store Entry objects
  List<Entry> entries;

  public Journal()
  {
    //Inicializa o construtor chamando a variavel entries e depois criando uma nova lista
    entries = new List<Entry>();
  }

  //função criada para fazer as perguntas e armazenar as respostas do usuario
  public void WriteNewEntry()
  {

    //Concole das perguntas
    Console.WriteLine("Please choose a prompt:");
    Console.WriteLine("1. Who was the most interesting person I interacted with today?");
    Console.WriteLine("2. What was the best part of my day?");
    Console.WriteLine("3. How did I see the hand of the Lord in my life today?");
    Console.WriteLine("4. What was the strongest emotion I felt today?");
    Console.WriteLine("5. If I had one thing I could do over today, what would it be?");

    //converte a resposta para int
    int choice = int.Parse(Console.ReadLine());
    //string criada para armazenar a pergunta prompt
    string prompt = "";

    //o usuario poderá escolher qual pergunta quer responder
    switch (choice)
    {
      case 1:
        prompt = "Who was the most interesting person I interacted with today?";
        break;
      case 2:
        prompt = "What was the best part of my day?";
        break;
      case 3:
        prompt = "How did I see the hand of the Lord in my life today?";
        break;
      case 4:
        prompt = "What was the strongest emotion I felt today?";
        break;
      case 5:
        prompt = "If I had one thing I could do over today, what would it be?";
        break;
      default:
        Console.WriteLine("Invalid choice. Please try again.");
        return;
    }

    Console.WriteLine($"Please enter your response for the question {choice}:");
    Console.WriteLine($"{prompt}");
    string response = Console.ReadLine();

    //cria uma variavel com o construtor armazenando a pergunta e a resposta do usuario
    Entry newEntry = new Entry(prompt, response);

    //adiciona a pergunta e a resposta na lista "entries"
    entries.Add(newEntry);

    //printa uma mensagem de sucesso
    Console.WriteLine("New entry added!");
  }


  public void DisplayJournal()
  {
    //se a lista estiver vazia vai dar um console de diario vazio
    if (entries.Count == 0)
    {
      Console.WriteLine("Journal is empty.");
    }
    //se tiver alguma informação salva vai printar data, pergunta e resposta
    else
    {
      Console.WriteLine("Journal entries:");
      //Entry = class Entry | entry = nova variavel | entries = lista de entries 
      foreach (Entry entry in entries)
      {
        Console.WriteLine("Date: {0}", entry.date.ToShortDateString());
        Console.WriteLine("Prompt: {0}", entry.prompt);
        Console.WriteLine("Response: {0}", entry.response);
        Console.WriteLine();
      }
    }
  }

  public void SaveJournalToFile(string fileName)
  {
    try
    {
      using (StreamWriter writer = new StreamWriter(fileName))
      {
        foreach (Entry entry in entries)
        {
          string formattedDate = entry.date.ToString("yyyy/MM/dd");
          writer.WriteLine("{0},{1},{2}", formattedDate, entry.prompt, entry.response);
        }
      }
      Console.WriteLine("Journal saved to file.");
    }
    catch (Exception e)
    {
      Console.WriteLine("Error saving journal to file: {0}", e.Message);
    }
  }

  public void LoadJournalFromFile(string fileName)
  {
    try
    {
      // Cria uma nova lista de entradas
      List<Entry> newEntries = new List<Entry>();

      // Abre o arquivo para leitura
      using (StreamReader reader = new StreamReader(fileName))
      {
        // Loop enquanto o arquivo não chegar ao fim
        while (!reader.EndOfStream)
        {
          // Lê uma linha do arquivo
          string line = reader.ReadLine();

          // Divide a linha em campos usando a vírgula como separador
          string[] fields = line.Split(',');

          // Converte a data do campo 0 para o tipo DateTime
          DateTime date = DateTime.Parse(fields[0]);

          // Atribui os valores dos campos 1 e 2 a variáveis
          string prompt = fields[1];
          string response = fields[2];

          // Cria uma nova entrada usando os valores dos campos e a data convertida
          Entry newEntry = new Entry(prompt, response, date);

          // Adiciona a nova entrada à lista de entradas
          newEntries.Add(newEntry);
        }
      }

      // Substitui as entradas existentes pelas novas entradas
      entries = newEntries;

      // Exibe mensagem indicando que o carregamento foi concluído com sucesso
      Console.WriteLine("Journal loaded from file.");
    }
    // Captura uma exceção caso ocorra algum erro durante a leitura do arquivo
    catch (Exception e)
    {
      // Exibe mensagem de erro
      Console.WriteLine("Error loading journal from file: {0}", e.Message);
    }
  }

}

