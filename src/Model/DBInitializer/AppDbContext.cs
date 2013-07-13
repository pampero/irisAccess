using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using Framework.Models;
using Model.Mappings;

namespace Model
{
    
    public class AppDbContext: DbContext
    {
        public AppDbContext()
            : base("Name=AppDbContext")
        {
            this.Configuration.LazyLoadingEnabled = true;
            Configuration.AutoDetectChangesEnabled = true;
        }

        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<UserProfile> UserProfiles{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
