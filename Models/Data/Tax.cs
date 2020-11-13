using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
   public class Tax
    {
        public int ID { get; set; }
        public string TaxPercent { get; set; }
        public string TaxValue { get; set; }
    }
}
