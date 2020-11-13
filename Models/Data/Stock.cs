using System;

namespace Models.Data
{
    public class Stock 
    {

        public int ID { get; set; }
        public int ProductID { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceDate { get; set; }
        public decimal Rate { get; set; }     
        public int Units { get; set; }
        public decimal ProductRate { get; set; }   
        
        public string InvoicePerson { get; set; }
        //public decimal TaxAmount { get; set; }
        public string InvoiceGSTN { get; set; }
        public TransitionType TransitionMethod { get; set; }
        public ActionType ActionType { get; set; }
        public StockType StockType { get; set; }

    }
}
