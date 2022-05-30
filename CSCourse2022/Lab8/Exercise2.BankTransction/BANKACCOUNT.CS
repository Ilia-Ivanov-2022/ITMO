using System.Collections;
class BankAccount 
{
	private long accNo;
    private decimal accBal;
    private AccountType accType;
    private Queue transQueue = new Queue();
    
    private static long nextNumber = 123;

    public BankAccount()
    {
        accNo = NextNumber();
        accType = AccountType.Checking;
        accBal = 0;
    }

    public BankAccount(AccountType aType)
    {
        accNo = NextNumber();
        accType = aType;
        accBal = 0;
    }

    public BankAccount(decimal aBal)
    {
        accNo = NextNumber();
        accType = AccountType.Checking;
        accBal = aBal;
    }
    public BankAccount(AccountType aType, decimal aBal)
    {
        accNo = NextNumber();
        accType = aType;
        accBal = aBal;
    }

    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds)
        {
            accBal -= amount;
            BankTransaction trans = new BankTransaction(-amount);
            transQueue.Enqueue(trans);
        }
        return sufficientFunds;
    }
    
    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        BankTransaction tran = new BankTransaction(amount);
        transQueue.Enqueue(tran);
        return accBal;
    }
    
    public Queue Transactions()
    {
        return transQueue;
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
        return nextNumber++;
    }
}
