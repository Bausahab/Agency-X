using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{ 
    public partial class UC_Quantity : UserControl
    {
        Models.AgencyDbContext prodStockContext;
        int pid;
        public UC_Quantity()
        {
            InitializeComponent();
            
        }
        public UC_Quantity(int productId):this()
        {
            pid = productId;

        }
        private void UC_Quantity_Load(object sender, EventArgs e)
        {
            using (prodStockContext = new Models.AgencyDbContext())
            {
                //get product name
                var selectedProduct = prodStockContext.PRODUCTS.Single(w => w.ID == pid);
                lblProdName.Text = selectedProduct.ProductName;
                //units per product
                int unitCnt = selectedProduct.UnitsCount;
                //collection of single product to sum units
                var datalist = (from y in prodStockContext.INVENTORY
                                where y.ProductID.Equals(pid)
                                select y).ToList();
               
                int rr = datalist.Sum(o => o.Units);
                //get boxes
                
                int exactBoxQty = rr / unitCnt;
                tbBoxQty.Text = exactBoxQty.ToString();
                int yy = rr % unitCnt;
                tbUnitQty.Text = yy.ToString();

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
