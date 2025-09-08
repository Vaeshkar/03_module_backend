// classes and objects example:
// PuzzleBox
var box1 = new PuzzleBox("Dennis", "Golden Key");
box1.Open(); // Opens the box – Golden Key

var box2 = new PuzzleBox("Adriaan", "Silver Key");
box2.Open(); // Opens the box – Silver Key
box2.Secret = "Bronze Key"; // Change the secret
box2.Open(); // Opens the box – Bronze Key

public class PuzzleBox
{
  // Fields
  private string _secret = "Empty";

  // Constructor
  public PuzzleBox(string owner, string secret)
  {
    Owner = owner;
    Secret = secret;
  }

  // Properties
  public string Secret
  {
    get { return _secret; }
    set { _secret = value; }
  }

  // Auto-implemented property
  public string Owner { get; set; }

  // Methods
  public void Open()
  {
    Console.WriteLine($"{Owner} opens the box and finds {Secret}.");
  }
}
