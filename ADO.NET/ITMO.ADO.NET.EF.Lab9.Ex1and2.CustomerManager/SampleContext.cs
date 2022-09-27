using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using static ITMO.ADO.NET.EF.Lab9.Ex1_2.CodeFirst.Model;

namespace ITMO.ADO.NET.EF.Lab9.Ex1and2.CustomerManager
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("MyShop")
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }

}
