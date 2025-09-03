using Utils;

Console.WriteLine("Value task");
int myValue = 5;

Console.WriteLine($"Calling Bump before change, {myValue}");
ValueDemo.Bump(myValue);
Console.WriteLine($"Calling Bump after change, {myValue}");

Console.WriteLine("'Ref' task");
int swapValue1 = 5;
int swapValue2 = 10;
Console.WriteLine($"Calling Swap before change. SwapValue1: {swapValue1}, SwapValue2: {swapValue2}");
RefOps.Swap(ref swapValue1, ref swapValue2);
Console.WriteLine($"Calling Swap after change. SwapValue1: {swapValue1}, SwapValue2: {swapValue2}");

Console.WriteLine("'Out' task");
string[] testPrices = { "$12.50", "€15,99", "£22.75", "100", "invalid" };

foreach (string testPrice in testPrices)
{
  bool success = Parser.TryParsePrice(testPrice, out decimal price);
  Console.WriteLine($"Input: {testPrice}, Output: {price}, Success: {success}.");
}
