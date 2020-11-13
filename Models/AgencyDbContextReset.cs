using Models.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AgencyDbContextReset : DbContext
    {
        public DbSet<Product> PRODUCTS { get; set; }
        public DbSet<Tax> GST { get; set; }
        public DbSet<Stock> INVENTORY { get; set; }
        public DbSet<InvoiceItems> RECEIPTiTEMS { get; set; }

        public AgencyDbContextReset() : base("name=AgecyConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<AgencyDbContext>());
        }
    }
}
