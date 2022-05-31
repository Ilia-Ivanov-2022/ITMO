
    using System;
    using System.IO;

    /// <summary>
    ///   A BankTransaction is created every time a deposit or withdrawal occurs on a BankAccount
    ///   A BankTransaction records the amount of money involved, together with the current date and time.
    /// </summary>
    public class BankTransaction
    {
		private readonly decimal amount;
		private readonly DateTime when;

        public BankTransaction(decimal tranAmount)
	    {
		   amount = tranAmount;
		   when = DateTime.Now;
	    }

		public decimal Amount()
		{
			return amount;
		}

		public DateTime When()
		{
			return when;
		}		
    }

