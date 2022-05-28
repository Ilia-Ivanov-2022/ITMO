using System;

public class Test
{
    public static void Main()
    {
        BankAccount ba1 = new BankAccount();
        ba1.Populate(100);
                
        BankAccount ba2 = new BankAccount ();
        ba2.Populate(100);

        Console.WriteLine("Before Transfer:\nAccount type: {0}\tAccount number: {1}\tAccount balance: {2}",
                          ba1.Type(),
                          ba1.Number(),
                          ba1.Balance());
        Console.WriteLine("Before Transfer:\nAccount Type: {0}\tAccount number: {1}\tAccount balance: {2}",
                          ba2.Type(),
                          ba2.Number(),
                          ba2.Balance());

        ba1.TransferFrom(ba2, 10);

        Console.WriteLine("After Transfer:\nAccount type: {0}\tAccount number: {1}\tAccount balance: {2}",
                          ba1.Type(),
                          ba1.Number(),
                          ba1.Balance());
        Console.WriteLine("After Transfer:\nAccount Type: {0}\tAccount number: {1}\tAccount balance: {2}",
                          ba2.Type(),
                          ba2.Number(),
                          ba2.Balance());
    }
}