using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
  public class StockList
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; } = 0.00M;
        public int Qty { get; set; }
        public string Unit { get; set; }
        public decimal BasicPrice { get; set; } = 0.00M;
        public decimal TaxAmount { get; set; } = 0.00M;    
        public decimal ProductRate { get; set; } = 0.00M;
        //public decimal Actualrte { get; set; } = 0.00M;
        //public decimal inctax { get; set; } = 0.00M;

    }
}
