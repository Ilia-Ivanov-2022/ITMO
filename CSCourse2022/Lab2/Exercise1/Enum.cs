using System;

namespace ITMO.CSCourse2022.Lab2.Exercise1
{
    public enum AccountType { Checking, Deposit }
    internal class Enum
    {
        static void Main(string[] args)
        {
            AccountType goldAccount, platinumAccount;

            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);
        }
    }
}
