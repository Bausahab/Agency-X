using Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
   public class ProductList
    {
        public int id { get; set; }
        public string ProductName { get; set; }
        public string GST { get; set; }
        public string HSN { get; set; }
        public int UnitsCount { get; set; }
        public Status Condition { get; set; }
    }
}
