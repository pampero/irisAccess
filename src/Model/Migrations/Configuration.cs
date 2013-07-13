
namespace Model.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Threading;
    using Framework.Models;

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
            var attributeAirConditioner = new Model.Attribute { Name = "Aire Acondicionado", Created = DateTime.Now, CreatedBy = "cvazquez"};
            var attributeParking = new Model.Attribute { Name = "Estacionamiento", Created = DateTime.Now, CreatedBy = "cvazquez" };
            var attributeCashOnly = new Model.Attribute { Name = "No Acepta Tarjetas", Created = DateTime.Now, CreatedBy = "cvazquez" };
            var attributeTakesReservation = new Model.Attribute { Name = "Toma Reservas", Created = DateTime.Now, CreatedBy = "cvazquez" };

            appDbContext.Attributes.AddOrUpdate(c => c.Name, attributeAirConditioner);
            appDbContext.Attributes.AddOrUpdate(c => c.Name, attributeParking);
            appDbContext.Attributes.AddOrUpdate(c => c.Name, attributeCashOnly);
            appDbContext.Attributes.AddOrUpdate(c => c.Name, attributeTakesReservation);

            appDbContext.Roles.AddOrUpdate(new Rol { Name="Admin"});
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
