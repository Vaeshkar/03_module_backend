using System;
using System.Collections.Generic;
using Utils;

namespace BookLibrary
{
  class Program
  {
    static void Main(string[] args)
    {
      {
        List<Book> books = new List<Book>();

        // Functions

        string ReadNonEmpty(string prompt)
        {
          string input;
          do
          {
            Console.WriteLine(prompt);
            input = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(input))
            {
              Console.WriteLine();
              Console.WriteLine("Input cannot be empty. Please try again.");
            }
          } while (string.IsNullOrEmpty(input));
          return input;
        }

        int ReadYear(string prompt)
        {
          int year;
          while (true)
          {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().Trim();
            if (int.TryParse(input, out year))
            {
              return year;
            }
            Console.WriteLine();
            Console.WriteLine("Please enter a valid year.");
          }
        }

        Book? FindByTitle(string title)
        {
          return books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        void AddBook()
        {
          Console.WriteLine();
          string title = ReadNonEmpty("Enter the title of the book: ");
          string author = ReadNonEmpty("Enter the autor of the book: ");
          int year = ReadYear("Enter the year of the book: ");
          if (FindByTitle(title) != null)
          {
            Console.WriteLine();
            Console.WriteLine("Book already exists.");
            return;
          }

          Book book = new Book(title, author, year);
          books.Add(book);
          Console.WriteLine();
          Console.WriteLine($"Book {book.Title} added successfully.");
        }

        void GetBook()
        {
          Console.WriteLine();
          string title = ReadNonEmpty("Enter the title of the book: ");
          Book? book = FindByTitle(title);

          if (book != null)
          {
            Console.WriteLine();
            Console.WriteLine("Book found: ");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"Year: {book.Year}");
            Console.WriteLine();
          }
          else
          {
            Console.WriteLine();
            Console.WriteLine("Book not found.");
          }
        }

        void EditBook()
        {
          Console.WriteLine();
          string title = ReadNonEmpty("Enter the title of the book: ");
          Book? book = FindByTitle(title);

          if (book != null)
          {
            Console.WriteLine();
            Console.WriteLine("Curent book details: ");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"Year: {book.Year}");
            Console.WriteLine();
            Console.WriteLine("Enter new details: ");
            book.Title = ReadNonEmpty("Title: ");
            book.Author = ReadNonEmpty("Author: ");
            book.Year = ReadYear("Year: ");

            Console.WriteLine("Book details updated successfully.");
            Console.WriteLine();
          }
        }

        void RemoveBook()
        {
          Console.WriteLine();
          string title = ReadNonEmpty("Enter the title of the book: ");
          Book? book = FindByTitle(title);

          if (book != null)
          {
            books.Remove(book);
            Console.WriteLine();
            Console.WriteLine($"Book {book.Title} removed succesfully.");
          }
          else
          {
            Console.WriteLine();
            Console.WriteLine("Book not found.");
          }
        }

        void ListAllBooks()
        {
          if (books.Count == 0)
          {
            Console.WriteLine("No Bbooks in the library.");
          }
          else
          {
            Console.WriteLine();
            Console.WriteLine("List of all books: ");
            foreach (Book book in books)
            {
              Console.WriteLine($"{book.Title} by {book.Author} ({book.Year})");
              Console.WriteLine();
            }
          }
        }

        // Main loop
        while (true)
        {
          Console.WriteLine("\nWhat would you like to do?");
          Console.WriteLine("1. Add a book");
          Console.WriteLine("2. Get a book");
          Console.WriteLine("3. Edit a book");
          Console.WriteLine("4. Remove a book");
          Console.WriteLine("5. List all books");
          Console.WriteLine("6. Exit");
          Console.WriteLine("Enter your choice (1-6): ");

          string choice = Console.ReadLine()?.Trim();

          switch (choice)
          {
            case "1":
              AddBook();
              break;
            case "2":
              GetBook();
              break;
            case "3":
              EditBook();
              break;
            case "4":
              RemoveBook();
              break;
            case "5":
              ListAllBooks();
              break;
            case "6":
              Console.WriteLine("Goodbye!");
              return;
            default:
              Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
              break;
          }
        }
      }
    }
  }
}
