using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
    public class InvoiceItems
    {
        public int ID { get; set; }
        public string RECEIPT_NO { get; set; }
        public string DATED { get; set; }
        public string INVOICEPERSON { get; set; }
        //public string DISCRIPTION { get; set; }
        //public string HSN { get; set; }
        //public string Qty { get; set; }
        //public string Units { get; set; }
        //public string UNITRATE { get; set; }
        //public string GST { get; set; }
        public string TOTAL { get; set; }
        public InvoiceType InvoiceState { get; set; }
    }
}
