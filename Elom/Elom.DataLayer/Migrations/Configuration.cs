using Elom.Model;

namespace Elom.DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Elom.DataLayer.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            // ok to destroy data during migrations process
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Elom.DataLayer.SalesContext context)
        {
            // seeding the database
            context.SalesOrders.AddOrUpdate(
                so => so.CustomerName,
                new SalesOrder{CustomerName = "Han", PONumber = "0122"},
                new SalesOrder{CustomerName = "Luke", PONumber = "0124"},
                new SalesOrder{CustomerName = "Lando", PONumber = "0125"},
                new SalesOrder{CustomerName = "Chewy", PONumber = "0126"}
                );
        }
    }
}
