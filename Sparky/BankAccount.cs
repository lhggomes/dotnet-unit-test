namespace Sparky;

public class BankAccount
{
    public int Balance { get; set; } = 0;
    private readonly ILogBook _logBook;
    
    public BankAccount(ILogBook logBook)
    {
        _logBook = logBook;
    }

    public bool Deposit(int amount)
    {
        Balance += amount;
        return true;
    }

    public bool WithDraw(int amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            return true;
        }

        return false;
    }
    
}