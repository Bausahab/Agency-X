using Models.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
    public class Stock
    {

        public int ID { get; set; }
        public int ProductID { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int TotalInvoiceQty { get; set; }

        public decimal InvoiceAmount { get; set; }
        public decimal InvoiceTaxAmount { get; set; }
        public string InvoiceFrom { get; set; }       
        public TransitionType transitionMethod { get; set; }
        public StockAction StockType { get; set; }
        public QuantityType StockStatus { get; set; }



    }
}
