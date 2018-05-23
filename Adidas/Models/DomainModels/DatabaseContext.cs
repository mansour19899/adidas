using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Adidas.Models.DomainModels
{
    public class DatabaseContext:DbContext
    {
        static DatabaseContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext,Migrations.Configuration >());
        }

        public DbSet<Person> People { get; set; }
        public DbSet<JobRecord> JobRecords { get; set; }
        public DbSet<RelationShip> RelationShips { get; set; }
    }
}