using System;
using System.Data.Entity.Migrations;

namespace Model.Migrations
{
    internal sealed partial class Configuration : DbMigrationsConfiguration<Model.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Model.AppDbContext appDbContext)
        {
           SeedBuisness(appDbContext);
        }

        private static void SeedBuisness(Model.AppDbContext appDbContext)
        {
            appDbContext.Roles.AddOrUpdate(new Rol { Name = "Admin" });
            appDbContext.Roles.AddOrUpdate(new Rol { Name = "Guest" });
            appDbContext.SaveChanges();

            var rol = appDbContext.Roles.Find(1);

            appDbContext.UserProfiles.AddOrUpdate(new UserProfile
            {
                Password = "Passw0rd",
                Email = "carlos@correocaliente.com",
                UserName = "cvazquez",
                Rol = rol
            });
            appDbContext.SaveChanges();
        }
    }
}
