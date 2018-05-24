namespace Adidas.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Adidas.Models.DomainModels;

    internal sealed class Configuration : DbMigrationsConfiguration<Adidas.Models.DomainModels.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Adidas.Models.DomainModels.DatabaseContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Adidas.Models.DomainModels.DatabaseContext context)
        {
            //DatabaseContext db = new DatabaseContext();
            
            //if(db.People.Count()==0)
            //{
            //    Person per = new Person()
            //    {
            //        Name = "manour",
            //        LastName = "mohammadi"
            //    };
            //    db.People.Add(per);
            //    db.SaveChanges();
            //}


        }
    }
}
