using self01.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace self01.DAL
{
    public class self01Context : DbContext
    {
        public self01Context() : base("self01Context")
        {
        }
        
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Location>()
                .HasMany(l => l.ChildLocations)
                .WithOptional()
                .HasForeignKey(l => l.topLocationID);
        }
    }
}


    
