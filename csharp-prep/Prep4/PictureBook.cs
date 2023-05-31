using System;

public class PictureBook : Book
{
  private string _ilustrator = "";

  public PictureBook() : base()
  {
    
  }
  public PictureBook(string author, string title, string ilustrator) : base(author, title)
  {
    _ilustrator = ilustrator;
  }
  public string GetIlustrator()
  {
    return _ilustrator;
  }

  public void SetIlustrator(string ilustrator)
  {
    _ilustrator = ilustrator;
  }

  public string GetPictureBookInfo()
  {
    return $"{_title} by {_author} ilustrate by {_ilustrator}";
  }

}