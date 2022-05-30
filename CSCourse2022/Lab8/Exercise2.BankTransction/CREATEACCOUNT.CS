
using System;

class CreateAccount
{
    // Test Harness
    static void Main() 
    {
        BankAccount acc1, acc2, acc3, acc4;
        acc1 = new BankAccount();
        acc2 = new BankAccount(AccountType.Deposit);
        acc3 = new BankAccount(100);
        acc4 = new BankAccount(AccountType.Deposit, 500);
        
        CreateAccount.Write(acc1);
        CreateAccount.Write(acc2);
        CreateAccount.Write(acc3);
        CreateAccount.Write(acc4);
                
    }
      
    static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number is {0}",  acc.Number());
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());

        Console.WriteLine("Transactions:");
        foreach(BankTransaction tran in acc.Transactions())
        {
            Console.WriteLine("Date/ Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
        }
        Console.WriteLine();
    }
}
