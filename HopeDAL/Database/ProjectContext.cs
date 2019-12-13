using HopeDAL.Mappings;
using HopeEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeDAL.Database
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        //base:(**)
        {
            Configuration.LazyLoadingEnabled = false; // DEFAULT TRUE

            Database.Connection.ConnectionString = @"Server=.;Database=HOPEProjectDB;User Id=bilgeadam;Password=123;";
        }

        public DbSet<News> News { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new CategoryMapping());
        }
    }
}
