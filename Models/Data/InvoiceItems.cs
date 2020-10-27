using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
   public class InvoiceItems
    {
        string RECEIPT_NO { get; set; }
        string DATED { get; set; }
        string INVOICEPERSON { get; set; }
        string DISCRIPTION { get; set; }
        string HSN { get; set; }
        string Qty { get; set; }
        string Units { get; set; }
        string UNITRATE { get; set; }
        string GST { get; set; }
        string TOTAL { get; set; }
        public Logic.InvoiceType InvoiceState { get; set; }
    }
}
