using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class StockValues

    {
        Models.AgencyDbContext stockvaluesContext;
      

         int ProductID { get; set; }
        


        public decimal ProductTaxRate(int prodID,decimal ProductRateWithTaxIncluded)
        {
            ProductID = prodID;
            decimal ProdTtlPrice = ProductRateWithTaxIncluded;
            using(stockvaluesContext = new Models.AgencyDbContext())
            {
                var selprod = stockvaluesContext.PRODUCTS.Single(u => u.ID == ProductID);
                int txid = selprod.TaxId;
                var txvalue = stockvaluesContext.GST.Single(y => y.ID == txid);
                decimal rs = ProdTtlPrice * ((100 / (100 + Convert.ToDecimal(txvalue.TaxValue))));
                return ProdTtlPrice - rs;
            }

            
        }
        public decimal ProductBasicPrice(decimal TaxRate,decimal ProductRateWithTaxIncluded)
        {
             decimal ProdBasePrice = ProductRateWithTaxIncluded - TaxRate;
            return ProdBasePrice;
        }
        public decimal ProductTaxAmount(decimal prodBaseprice, decimal ProductRateWithTaxIncluded)
        {
            decimal productTaxAmt = ProductRateWithTaxIncluded - prodBaseprice;
            return productTaxAmt;
        }
        
    }
}
