using System.Data.Entity;

namespace Laba7.Models
{
    public class ShipsContext : DbContext
    {
        public DbSet<Ships> Ships{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ShipsContext>(null);
            base.OnModelCreating(modelBuilder);
        }

    }
}