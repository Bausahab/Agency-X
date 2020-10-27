using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
   public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string HSN { get; set; }
        public int UnitsCount { get; set; }
        public Logic.Status Status { get; set; }
        //public string MFG { get; set; }
        //public string Catagory { get; set; }

    }
}
