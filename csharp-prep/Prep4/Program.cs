using System;

class Program
{
  static void Main(string[] args)
  {
    Book book1 = new Book();
    book1.SetAuthor("Pezzini");
    book1.SetTitle("The legend of a hero");
    Console.WriteLine(book1.GetBookInfo());

    PictureBook book2 = new PictureBook();
    book2.SetAuthor("Hatakeyama");
    book2.SetTitle("Wonderful History");
    book2.SetIlustrator("TOEI ANIMATION");

    Console.WriteLine(book2.GetPictureBookInfo());

    Book book3 = new Book("Zenit", "122");
    Console.WriteLine(book3.GetBookInfo());

    PictureBook book4 = new PictureBook("Potter", "A long time ago", "Shurima Impression");
    Console.WriteLine(book4.GetPictureBookInfo());

  }

}