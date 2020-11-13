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
    public partial class UCpurchaseStock : UserControl
    {
        Models.AgencyDbContext purContext;
        List<Models.Data.Product> ProdList = new List<Models.Data.Product>();
        List<Models.Data.Tax> gStList = new List<Models.Data.Tax>();
        List<Models.Data.Stock> addedStock = new List<Models.Data.Stock>();
        List<StockList> SelectionDisply = new List<StockList>();
        int lrn;
        int productID;
        decimal actulpri { get; set; } = 0.00M;
        decimal inclutax { get; set; } = 0.00M;
        decimal txper { get; set; } = 0.00M;
        //  List<Models.Data.Product>
        public UCpurchaseStock()
        {
            InitializeComponent();
        }

       
        private void UCpurchaseStock_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = addedStock;
            comboBox1.DataSource = Enum.GetValues(typeof(Models.Data.TransitionType));
            comboBox1.SelectedIndex = 0;
            comboBox2.DataSource = Enum.GetValues(typeof(Models.Data.StockType));
            comboBox2.SelectedIndex = 0;
            using (purContext = new Models.AgencyDbContext())
            {
                ProdList.AddRange(purContext.PRODUCTS.ToList());
                gStList.AddRange(purContext.GST.ToList());
                var jook = ProdList.Select(b => new { b.ID, b.ProductName,b.ProductSize,b.UnitsCount }).ToList();
                dgvDisp.DataSource = jook.ToList();
                dgvDisp.Columns["ID"].Visible = false;
            }
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            Models.Data.Stock addStock;
            #region Adding into Actual Stock to Upload further
            try
            {
                addStock = new Models.Data.Stock();
                foreach (StockList u in SelectionDisply)
                {
                   
                    addStock.ProductID = u.Id;
                    addStock.InvoiceDate = dateTimePicker1.Value.ToShortDateString(); ;
                    addStock.InvoiceNumber = tbInvoicenumber.Text;
                    addStock.ProductRate = u.ProductRate;
                    addStock.Rate = u.Rate;
                    var getunits = ProdList.Single(r => r.ID == u.Id);
                    addStock.Units = (int)nupQty.Value * getunits.UnitsCount;
                    addStock.StockType = (Models.Data.StockType)Enum.Parse(typeof(Models.Data.StockType), comboBox2.Text);
                    addStock.TransitionMethod = (Models.Data.TransitionType)Enum.Parse(typeof(Models.Data.TransitionType), comboBox1.Text);
                    addStock.ActionType = Models.Data.ActionType.Purchase;
                    addStock.InvoicePerson = tbInvoiceFrom.Text;
                    addedStock.Add(addStock);
                    using (purContext = new Models.AgencyDbContext())
                    {
                        purContext.INVENTORY.AddRange(addedStock);
                        purContext.SaveChanges();
                       
                        
                    }
                    MessageBox.Show("Records Added to STOCK");
                }
                this.Dispose();
            }
            catch (Exception tt)
            {
                MessageBox.Show(tt.Message + "\n" + "Fill All Values and Try Again");
            }
            #endregion
            this.Dispose();
        }

        private void TBfINALaMT_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBfINALaMT.Text))
                tbTotalAmt.Text = TBfINALaMT.Text;

                //tbTotalAmt.DataBindings.Add("Text", TBfINALaMT.Text, TBfINALaMT.Text);
        }

        private void NupQty_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUnitRate.Text))
            {
                decimal rte = Convert.ToDecimal(tbUnitRate.Text);
                tbTotalAmt.Text = (rte * nupQty.Value).ToString();
            }
        }

        private void TbUnitRate_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUnitRate.Text))
            {
                decimal rte = Convert.ToDecimal(tbUnitRate.Text);
                tbTotalAmt.Text = (rte * nupQty.Value).ToString();
            }
        }

        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            
            try
            {
                StockList stockList = new StockList();
                var proNme = ProdList.Single(y => y.ID == productID);
                stockList.Id = productID;
                stockList.Description = proNme.ProductName;
                //var getunits = ProdList.Single(r => r.ID == productID);
                stockList.Qty = (int)nupQty.Value;
                stockList.Rate = Convert.ToDecimal(tbUnitRate.Text);
                stockList.TaxAmount = Convert.ToDecimal(tbTaxamt.Text);
                stockList.BasicPrice = Convert.ToDecimal(tbTotalAmt.Text);
                stockList.ProductRate = Convert.ToDecimal(TBfINALaMT.Text);
               
                SelectionDisply.Add(stockList);
                dataGridView1.DataSource = SelectionDisply.ToList();
                dataGridView1.Columns["Id"].Visible = false;

                actulpri = Convert.ToDecimal(tbUnitRate.Text);
                txper = Convert.ToDecimal(lblTaxPercent.Text);
                inclutax = actulpri * (100 / (100 + txper));

                //decimal.Round((stockList.Actualrte = (nupQty.Value * inclutax)), 2, MidpointRounding.AwayFromZero);
                //decimal.Round((stockList.inctax = ((int)nupQty.Value * (actulpri - inclutax))), 2, MidpointRounding.AwayFromZero);
                
                    decimal jj = Convert.ToDecimal(SelectionDisply.Sum(o => o.ProductRate));
                tbProdrate.Text = decimal.Round(jj).ToString();
            }
            catch { MessageBox.Show("try again"); }
            //dataGridView1.DataSource = addedStock.ToList();
            //dataGridView1.Columns["ID"].Visible = false;
            //dataGridView1.Columns["ProductID"].Visible = false;

        }

        private void DgvDisp_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            productID = Convert.ToInt32(dgvDisp.Rows[e.RowIndex].Cells[0].Value.ToString());
            var selectedprod = ProdList.Single(p => p.ID == productID);
            var seleTax = gStList.Single(g => g.ID == selectedprod.TaxId);
            lblUnits.Text = selectedprod.UnitsCount.ToString();
            lblTaxPercent.Text = seleTax.TaxValue.ToString();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            lrn = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
           
           
        }

        private void TbInvoicenumber_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbInvoicenumber.Text))
            {
                tbInvoicenumber.BackColor = Color.LightSalmon;
            }
            else
            {
                tbInvoicenumber.BackColor = Color.YellowGreen;
                tbInvoicenumber.ForeColor = Color.Blue;
            }
        }

        private void BtnRemStock_Click(object sender, EventArgs e)
        {
            try
            {

                var oo = SelectionDisply.LastOrDefault(y => y.Id == lrn);
                SelectionDisply.Remove(oo);
                dataGridView1.DataSource = SelectionDisply.ToList();
            }
            catch { MessageBox.Show("try again"); }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string oo;
            string rr = tbTotalAmt.Text;
            if (!string.IsNullOrEmpty(tbTotalAmt.Text))
            {
                using (purContext = new Models.AgencyDbContext())
                {
                    var selectedprod = ProdList.Single(p => p.ID == productID);
                    var seleTax = gStList.Single(g => g.ID == selectedprod.TaxId);

                    oo = seleTax.TaxValue;
                    decimal txamt = ((Convert.ToDecimal(tbTotalAmt.Text)) * ((Convert.ToDecimal(oo)) / 100));
                    tbTaxamt.Text = txamt.ToString();
                    TBfINALaMT.Text = ((Convert.ToDecimal(tbTaxamt.Text)) +(Convert.ToDecimal(rr))).ToString();
                    tbTotalAmt.Text = rr;
                }

            }
        }
    }
}
