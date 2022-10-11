using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO.ASP.NET.MVC.Lab4.MvcCreditApp1.Models
{
    public class Credit
    {
        // ID кредита.
        public virtual int CreditId { get; set; }
        // Название.
        public virtual string Head { get; set; }
        // Период, на который выдается кредит.
        public virtual int Period { get; set; }
        // Максимальная сумма кредита.
        public virtual int Sum { get; set; }
        // Процентная ставка.
        public virtual int Procent { get; set; }
    }
}