using System.Data.Entity;
using static ITMO.ADO.NET.EF.Lab9.Ex1_2.CodeFirst.Model;

namespace ITMO.ADO.NET.EF.Lab9.Ex1_2.CodeFirst
{
    public class SampleContext : DbContext
    {
        // Ctor of base class with explicit name of DB.
        public SampleContext() : base("MyShop")
        { }
        // References to tables as props.
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
