class Entry
{
  public DateTime date;
  public string prompt;
  public string response;

  public Entry(string prompt, string response)
  {
    date = DateTime.Now;
    this.prompt = prompt;
    this.response = response;
  }

  public Entry(string prompt, string response, DateTime date)
  {
    this.date = date;
    this.prompt = prompt;
    this.response = response;
  }

}