namespace Utils; // file-scoped namespace

// Create a public calculator class
public class Calculator
{
  // Create a public add method that takes int
  public static int Add(int a, int b)
  {
    return a + b;
  }

  // Create a public add method that takes a double
  public static double Add(double a, double b)
  {
    return a + b;
  }

  // Create a public multiply method that takes int
  public static int Multiply(int a, int b)
  {
    return a * b;
  }

  // Create a public divide method that takes a double
  public static double Divide(double a, double b)
  {
    if (b == 0)
    {
      return double.NaN; // Not a Number
    }
    return a / b;
  }


}
