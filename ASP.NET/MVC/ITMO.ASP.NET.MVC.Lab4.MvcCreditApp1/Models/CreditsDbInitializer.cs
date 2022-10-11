using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITMO.ASP.NET.MVC.Lab4.MvcCreditApp1.Models
{
    public class CreditsDbInitializer : DropCreateDatabaseIfModelChanges<CreditContext>
    {
        protected override void Seed(CreditContext context)
        {
            context.Credits.Add(new Credit
            {
                Head = "Ипотечный кредит",
                Period = 10,
                Sum = 1000000,
                Procent = 15
            });
            context.Credits.Add(new Credit
            {
                Head = "Образовательный кредит",
                Period = 7,
                Sum = 300000,
                Procent = 10
            });
            context.Credits.Add(new Credit
            {
                Head = "Потребительский кредит",
                Period = 5,
                Sum = 500000,
                Procent = 19
            });
            base.Seed(context);
        }
    }
}