// Book class
namespace Utils;

public class Book
{
  // Properties
  public string Title { get; set; }
  public string Author { get; set; }
  public int Year { get; set; }

  // Constructor
  public Book(string title, string author, int year)
  {
    Title = title;
    Author = author;
    Year = year;
  }

  // Methods
  public void DisplayInfo()
  {
    // Display book information
    Console.WriteLine("-----------------------");
    Console.WriteLine("\n");
    Console.WriteLine("Book Info:");
    Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}");
    Console.WriteLine("\n");
    Console.WriteLine("-----------------------");
  }
}
