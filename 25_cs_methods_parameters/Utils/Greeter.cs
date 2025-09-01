using System;

namespace Utils; // file-scoped namespace

public class Greeter
{
  public static void Welcome(string name = "Student", string course = "C# Basics")
  {
    {
      Console.WriteLine($"Welcome to {course}, {name}!");
    }
  }
}
