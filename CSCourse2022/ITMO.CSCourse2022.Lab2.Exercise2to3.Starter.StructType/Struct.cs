using System;

namespace ITMO.CSCourse2022.Lab2.Exercise2.Starter.StructType
{
    public enum AccountType { Checking, Depisit }
    public struct BankAccount { public long accNo; public decimal accBal; public AccountType accType; }
    internal class Struct
    {
        static void Main(string[] args)
        {
            BankAccount goldAccount;

            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal) 3200.00;
            //goldAccount.accNo = 123;                          artifact from Exercise #2
            Console.WriteLine("Please Account Number:");
            goldAccount.accNo = long.Parse(Console.ReadLine());

            Console.WriteLine("*** Account Summary ***");
            Console.WriteLine("Account Number {0}", goldAccount.accNo);
            Console.WriteLine("Account Type {0}", goldAccount.accType);
            Console.WriteLine("Account Balance {0}", goldAccount.accBal);
        }
    }
}
