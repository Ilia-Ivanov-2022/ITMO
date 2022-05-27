
class BankAccount 
{
    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        return amount;
    }
    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds)
        { 
            accBal -= amount;
        }
        return sufficientFunds;
    }
    public void Populate(decimal balance)
    {
        accNo = NextNumber();
        accBal = balance;
        accType = AccountType.Checking;
    }
    public long Number()
    {
        return accNo;
    }
    public decimal Balance()
    {
        return accBal;
    }
    public string Type()
    {
        return accType.ToString();
    }
    private static long NextNumber()
    {
        return nextAccNo++;
    }
    private long accNo;
    private decimal accBal;
    private AccountType accType;

    private static long nextAccNo = 123;

}
