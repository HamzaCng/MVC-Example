using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yayakos.Entities;
using Yayakos.Entities.Mappings;

namespace Yayakos.Dal
{
    class NorthwindDbContext:DbContext
    {
        public NorthwindDbContext():base("server=.;database=CakmaNorthwindDB;Trusted_Connection=true")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMapping());
            modelBuilder.Configurations.Add(new CategoryMapping());
            base.OnModelCreating(modelBuilder);
        }


    }
}
