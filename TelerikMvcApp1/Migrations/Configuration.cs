namespace TelerikMvcApp1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TelerikMvcApp1.Models.TestDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TelerikMvcApp1.Models.TestDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.TestEntities.AddOrUpdate(
              p => p.Title,
              new Models.TestEntity { Title = "Andrew Peters", Content = "Test Entity Content A", Type = Models.EntityType.A },
              new Models.TestEntity { Title = "Brice Lambson", Content = "Test Entity Content B", Type = Models.EntityType.B },
              new Models.TestEntity { Title = "Rowan Miller", Content = "Test Entity Content C", Type = Models.EntityType.C },
              new Models.TestEntity { Title = "Keith Damon", Content = "Test Entity Content D", Type = Models.EntityType.D }
            );
        }
    }
}
