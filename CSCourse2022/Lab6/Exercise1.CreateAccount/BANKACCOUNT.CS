
class BankAccount 
{
    public void Populate(long number, decimal balance)
    {
        number = accNo;
        balance = accBal;
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
    private long accNo;
    private decimal accBal;
    private AccountType accType;

}
