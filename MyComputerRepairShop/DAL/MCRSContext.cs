using MyComputerRepairShop.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MyComputerRepairShop.DAL
{
    public class MCRSContext : DbContext

    {

        public MCRSContext(): base("MCRSContext")
        {
        }

        public DbSet<Client> clients { get; set; }
        public DbSet<Worker> workers { get; set; }
        public DbSet<ComputerPart> computerParts { get; set; }  
        public DbSet<RepairJob> repairJobs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}