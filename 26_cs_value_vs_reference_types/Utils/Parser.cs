namespace Utils;

public class Parser
{
  public static bool TryParsePrice(string text, out decimal price)
  {
    string cleanText = text.Replace(",", "."); // replace comma with dot
    cleanText = cleanText.Replace("$", "").Replace("€", "").Replace("£", ""); // remove currency symbols

    if (decimal.TryParse(cleanText, out price)) // try to parse the text
    {
      return true; // return true if parsing succeeds
    }
    price = 0M; // set price to 0 if parsing fails
    return false; // return false if parsing fails
  }
}
