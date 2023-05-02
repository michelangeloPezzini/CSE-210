public class Job
{
  public string _company;
  public string _jobTitle;
  public int _startYear;
  public int _endYear;
  public void DisplayJobInformation()
  {
    Console.WriteLine("teste de commit");
    Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
  }
}