namespace Utils;

public static class RefOps
{
  public static void Swap(ref int a, ref int b)
  {
    int temp = a; // temporary value swap
    a = b;
    b = temp;
  }
}
