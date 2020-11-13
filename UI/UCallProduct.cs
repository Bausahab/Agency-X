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
    
    public partial class UCallProduct : UserControl
    {
        int productID;
        Models.AgencyDbContext AllProd;
        //public event EventHandler<string> ProductsRecordChanged;
        List<ProductList> dispProd = new List<ProductList>();
        List<Models.Data.Tax> tac = new List<Models.Data.Tax>();
        public UCallProduct()
        {
            InitializeComponent();
        }

        private void UCallProduct_Load(object sender, EventArgs e)
        {
            //ProductList pl = new ProductList();
            showdta();
           
        }

        private void DgvDisp_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            productID = Convert.ToInt32(dgvDisp.Rows[e.RowIndex].Cells[0].Value.ToString());

            using (AllProd = new Models.AgencyDbContext())
            {
                //get product name
                var selectedProduct = AllProd.PRODUCTS.Single(w => w.ID == productID);
                lblProdName.Text = selectedProduct.ProductName;
                //units per product
                int unitCnt = selectedProduct.UnitsCount;
                //collection of single product to sum units
                var datalist = (from y in AllProd.INVENTORY
                                where y.ProductID.Equals(productID)
                                select y).ToList();

                int rr = datalist.Sum(o => o.Units);
                //get boxes

                int exactBoxQty = rr / unitCnt;
                tbBoxQty.Text = exactBoxQty.ToString();
                int yy = rr % unitCnt;
                tbUnitQty.Text = yy.ToString();

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Do you want to delete this product?", "DELETING PRODUCT AND DATA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                try 
                    {
                        using (AllProd = new Models.AgencyDbContext())
                        {
                            var selectedprod = AllProd.PRODUCTS.Single(p => p.ID == productID);


                            AllProd.PRODUCTS.Remove(selectedprod);
                            AllProd.SaveChanges();
                          
                            tac.AddRange(AllProd.GST.ToList());
                            foreach (Models.Data.Product p in AllProd.PRODUCTS)
                            {

                                ProductList pl = new ProductList();
                                pl.id = p.ID;
                                pl.ProductName = p.ProductName;
                                pl.HSN = p.HSN;
                                var ii = tac.Single(u => u.ID == p.TaxId);
                                pl.GST = ii.TaxPercent;
                                pl.UnitsCount = p.UnitsCount;
                                pl.Condition = p.Status;
                                dispProd.Add(pl);
                            }
                            dgvDisp.DataSource = dispProd;
                            dgvDisp.Columns["id"].Visible = false;
                        }

                    }

            catch (Exception yy)
                {
                    MessageBox.Show(yy.Message + "Please select a record first");
                    
                }
            }
        }
        internal void showdta()
        {
            using (AllProd = new Models.AgencyDbContext())
            {
                tac.AddRange(AllProd.GST.ToList());
                foreach (Models.Data.Product p in AllProd.PRODUCTS)
                {

                    ProductList pl = new ProductList();
                    pl.id = p.ID;
                    pl.ProductName = p.ProductName+p.ProductSize+p.UnitsCount;
                    pl.HSN = p.HSN;
                    var ii = tac.Single(u => u.ID == p.TaxId);
                    pl.GST = ii.TaxPercent;
                    pl.UnitsCount = p.UnitsCount;
                    pl.Condition = p.Status;
                    dispProd.Add(pl);

                }
                dgvDisp.DataSource = dispProd;
                dgvDisp.Columns["id"].Visible = false;
            }
        }

        private void BtnShowStk_Click(object sender, EventArgs e)
        {
           
           
          
          
            // ps.Show();
        }
    }
}
