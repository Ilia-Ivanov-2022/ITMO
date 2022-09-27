using System.Data.Entity;

namespace ITMO.ADO.NET.EF.FinalTest.Crewing
{
    internal class CrewingContext : DbContext
    {
        public DbSet<Seafarer> Seafarers { get; set; }
        public DbSet<Vessel> Vessels { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}
