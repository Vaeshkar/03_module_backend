namespace Utils; // file-scoped namespace

public class Formatter
{
  public static string FormatNumber(int n)
  {
    return $"Number: {n}";
  }

  public static string FormatNumber(double n)
  {
    return $"Double: {n}";
  }

  public static string FormatMessage(string text, int repeat = 1)
  {
    return string.Concat(Enumerable.Repeat(text, repeat));
  }
}
