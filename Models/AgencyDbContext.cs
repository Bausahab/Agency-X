using Models.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AgencyDbContext : DbContext
    {
        public DbSet<Product> PRODUCTS { get; set; }
        public DbSet<Tax> GST { get; set; }
        public DbSet<Stock> INVENTORY { get; set; }
        public DbSet<InvoiceItems> RECEIPTiTEMS { get; set; }

        public AgencyDbContext() : base("name=AgecyConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AgencyDbContext>());
        }
    }
}
