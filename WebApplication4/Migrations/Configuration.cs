namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication4.Models.productDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebApplication4.Models.productDBContext";
        }

        protected override void Seed(WebApplication4.Models.productDBContext context)
        {
            //  This method will be called after migrating to the latest version.
            
            context.Products.AddOrUpdate(c => c.id,
          new Models.Product { id = 1,name="name1", description = @"description1" },
          new Models.Product { id = 2,name="name2", description = @"description2" }
          );
        }
    }
}
