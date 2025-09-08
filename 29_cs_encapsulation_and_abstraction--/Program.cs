// Inheritance example:
// BankAccount

var account = new BankAccount("Maria", 1000);
account.Deposit(250); // add money to the account

Console.WriteLine($"Balance: {account.Balance}");

public class BankAccount
{
  private decimal _balance; // private field

  public BankAccount(string owner, decimal initialBalance)
  {
    Owner = owner;
    _balance = initialBalance;
  }

  public void Deposit(decimal amount)
  {
    if (amount > 0)
    {
      _balance += amount;
    }
  }

  public decimal GetBalance()
  {
    return _balance;
  }
}
