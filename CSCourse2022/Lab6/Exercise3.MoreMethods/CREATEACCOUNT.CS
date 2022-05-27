
using System;

class CreateAccount
{
    public static void TestDeposit(BankAccount acc)
    {
        Console.Write("Please enter the amount to deposit: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        if (amount > 0)
        {
            acc.Deposit(amount);
        }
        else
        {
            acc.Deposit(0);
            Console.WriteLine("You entered an incorrect amount.");
        }
    }
    public static void TestWithdraw(BankAccount acc)
    {
        Console.Write("Please enter amount to withdraw: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        if (!acc.Withdraw(amount))
        {
            Console.WriteLine("Insufficient funds");
        }
    }
    static void Main() 
    {
        BankAccount berts = NewBankAccount();
        Write(berts);
        TestDeposit(berts);
        Write(berts);
        TestWithdraw(berts);
        Write(berts);
        
        BankAccount freds = NewBankAccount();
        Write(freds);
        TestDeposit(freds);
        Write(freds);
        TestWithdraw(freds);
        Write(freds);
    }
        
    
static BankAccount NewBankAccount()
    {       
        BankAccount created = new BankAccount();
                   
        Console.Write("Enter the account balance! : ");
        decimal balance = decimal.Parse(Console.ReadLine());

        created.Populate(balance);
        
        return created;
    }
    
    static void Write(BankAccount toWrite)
    {
        Console.WriteLine("Account number is {0}",  toWrite.Number());
        Console.WriteLine("Account balance is {0}", toWrite.Balance());
        Console.WriteLine("Account type is {0}", toWrite.Type());
    }
}
