using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("Name=AppDbContext")
        {
            this.Configuration.LazyLoadingEnabled = true;
            Configuration.AutoDetectChangesEnabled = true;
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Door> Doors { get; set; }
        public DbSet<HardwareModel> HardwareModels { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Terminal> Terminals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
