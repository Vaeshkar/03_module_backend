namespace Utils;

public static class Statistics
{
  // Method Average
  public static double Average(double a, double b, double c = 0)
  {
    if (c == 0)
    {
      return (a + b) / 2; // average of 2 numbers
    }
    else
    {
      return (a + b + c) / 3; // average of 3 numbers
    }
  }
};
