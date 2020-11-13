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
    public partial class UCsaleStock : UserControl
    {
       
        Models.AgencyDbContext purContext;
        List<Models.Data.Product> ProdList = new List<Models.Data.Product>();
        List<Models.Data.Tax> gStList = new List<Models.Data.Tax>();
        List<Models.Data.Stock> addedStock = new List<Models.Data.Stock>();
        List<StockList> SelectionDisply = new List<StockList>();
        int prodidlocal =0;
        public UCsaleStock()
        {
            InitializeComponent();
        }

        private void UCsaleStock_Load(object sender, EventArgs e)
        {
            dgvProd.DataSource = addedStock;
            cbInvoiceType.DataSource = Enum.GetValues(typeof(Models.Data.InvoiceType));
            cbInvoiceType.SelectedIndex = 0;
            cbTransType.DataSource = Enum.GetValues(typeof(Models.Data.TransitionType));
            cbTransType.SelectedIndex = 0;
            using (purContext = new Models.AgencyDbContext())
            {
                ProdList.AddRange(purContext.PRODUCTS.ToList());
                gStList.AddRange(purContext.GST.ToList());
                var jook = ProdList.Select(b => new { b.ID, b.ProductName, b.ProductSize, b.UnitsCount }).ToList();
                dgvProd.DataSource = jook.ToList();
                dgvProd.Columns["ID"].Visible = false;
            }

        }

        private void DataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            prodidlocal= Convert.ToInt32(dgvProd.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (prodidlocal != 0)
                groupBox1.Enabled = true;
            groupBox3.Enabled = true;
            groupBox1.Text = prodidlocal.ToString();
            groupBox3.Text = prodidlocal.ToString();
            var rr = ProdList.Single(t => t.ID == prodidlocal);
            nupunits.Maximum = rr.UnitsCount-1;

        }

        private void BtnAddToInvoice_Click(object sender, EventArgs e)
        {
            groupBox1.Text ="BOX/PACK";
            groupBox3.Text = "UNIT/PICES";
            groupBox3.Enabled = false;
            groupBox1.Enabled= false;
            StockList stockList = new StockList();

            try
            {


                var proNme = ProdList.Single(y => y.ID == prodidlocal);
                stockList.Id = prodidlocal;
                stockList.Description = proNme.ProductName + "-" + proNme.ProductSize + "X" + proNme.UnitsCount.ToString();
                stockList.Qty = (int)nupBoxes.Value;
                stockList.Unit = "Pack";
                stockList.Rate = Convert.ToDecimal(tbBoxRte.Text);
                stockList.BasicPrice = Decimal.Round(Convert.ToDecimal(tbBoxBasicPrice.Text));
                stockList.TaxAmount = Decimal.Round(Convert.ToDecimal(tbBoxTax.Text));
                stockList.ProductRate = Convert.ToDecimal(tbBoxPrice.Text);
               
                SelectionDisply.Add(stockList);
                dgvSelectedProd.DataSource = SelectionDisply.ToList();
                dgvSelectedProd.Columns["Id"].Visible = false;

                //decimal kk = Convert.ToDecimal(tbRte.Text);
                //txper = Convert.ToDecimal(lblTaxPercent.Text);
                //inclutax = actulpri * (100 / (100 + txper));

                //decimal.Round((stockList.Actualrte = (nupQty.Value * inclutax)), 2, MidpointRounding.AwayFromZero);
                //decimal.Round((stockList.inctax = ((int)nupQty.Value * (actulpri - inclutax))), 2, MidpointRounding.AwayFromZero);
                //tbProdrate.Text = SelectionDisply.Sum(o => o.ProductRate).ToString();
            }
            catch { MessageBox.Show("try again"); }
        }

        private void Nupqty_ValueChanged(object sender, EventArgs e)
        {
            decimal rate = Convert.ToDecimal(tbBoxRte.Text);
            tbBoxPrice.Text = (rate * nupBoxes.Value).ToString();
        }

        private void TbRte_Leave(object sender, EventArgs e)
        {
            //decimal rate = Convert.ToDecimal(tbRte.Text);
            //tbProdRate.Text = (rate * nupqty.Value).ToString();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Models.Data.Stock addStock;
            #region Adding into Actual Stock to Upload further
            try
            {
                addStock = new Models.Data.Stock();
                foreach (StockList u in SelectionDisply)
                {

                    addStock.ProductID = u.Id;
                    addStock.InvoiceDate = dtpSaleDate.Value.ToShortDateString();
                    addStock.InvoiceNumber = tbInvoNum.Text;
                    addStock.ProductRate = u.ProductRate;
                    addStock.Rate = u.Rate;
                    if(u.Unit=="Pack")
                    {
                        var getunit = ProdList.Single(r => r.ID == u.Id);
                        addStock.Units = - Convert.ToInt32(u.Qty * getunit.UnitsCount);
                    }
                    else
                    {
                        addStock.Units = -u.Qty;
                    }
                    addStock.StockType = Models.Data.StockType.Running;
                    addStock.ActionType = Models.Data.ActionType.Sale;
                    addStock.TransitionMethod = (Models.Data.TransitionType)Enum.Parse(typeof(Models.Data.TransitionType), cbTransType.Text);
                    addStock.InvoiceGSTN = tbGSTN.Text;
                    addStock.InvoicePerson = tbInvoiceTo.Text;
                    addedStock.Add(addStock);
                }
                using (purContext = new Models.AgencyDbContext())
                {
                    purContext.INVENTORY.AddRange(addedStock);
                    purContext.SaveChanges();
                    //int gg = addedStock.Count;
                    //MessageBox.Show(gg.ToString() + "Records Added");
                }

                Models.Data.InvoiceItems invoice = new Models.Data.InvoiceItems();
                invoice.INVOICEPERSON = tbInvoiceTo.Text;
                invoice.RECEIPT_NO = tbInvoNum.Text;
                invoice.TOTAL = SelectionDisply.Sum(o => o.ProductRate).ToString();
                invoice.DATED = dtpSaleDate.Value.ToShortDateString();
                invoice.InvoiceState = (Models.Data.InvoiceType)Enum.Parse(typeof(Models.Data.InvoiceType), cbInvoiceType.Text);
                invoice.DATED = dtpSaleDate.Value.ToShortDateString();
                //UCinvoce invo = new UCinvoce(invoice, SelectionDisply);
                //we need to transfer custom list to invoice.. major point 2
                Frminvoice jk = new Frminvoice(invoice, SelectionDisply);
                //jk.Controls.Add(invo);
                //invo.Dock = DockStyle.Fill;
                //invo.Show();
                jk.Show();
            }


            catch (Exception tt)
            {
                MessageBox.Show(tt.Message + "\n" + "Fill All Values and Try Again");
            }
            #endregion


        }

        private void TbProdRate_TextChanged(object sender, EventArgs e)
        {
            //if(!string.IsNullOrEmpty(tbProdRate.Text))
            //{
            //    StockValues sv = new StockValues();
            //    decimal kk = sv.ProductTaxRate(prodidlocal, Convert.ToDecimal(100));
            //    MessageBox.Show(kk.ToString());
            //   // tbBasicPri.Text  = sv.ProductBasicPrice(kk, Convert.ToDecimal(tbProdRate.Text)).ToString();
            //   //tbTxamt.Text = sv.ProductTaxAmount(stockList.BasicPrice, Convert.ToDecimal(tbProdRate.Text)).ToString();
            //}
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbBoxPrice.Text))
            {
                StockValues sv = new StockValues();
                decimal kk = sv.ProductTaxRate(prodidlocal, Convert.ToDecimal(tbBoxPrice.Text));
                decimal jj = sv.ProductBasicPrice(kk, Convert.ToDecimal(tbBoxPrice.Text));
                
                tbBoxBasicPrice.Text =(Decimal.Round( jj)).ToString();
                decimal yy= sv.ProductTaxAmount(Convert.ToDecimal(tbBoxBasicPrice.Text), Convert.ToDecimal(tbBoxPrice.Text));
                tbBoxTax.Text =(Decimal.Round(yy)).ToString();
            }
        }

        private void Nupunits_ValueChanged(object sender, EventArgs e)
        {

            decimal rate = Convert.ToDecimal(tbUnitRte.Text);
            tbUnitPrice.Text = (rate * nupunits.Value).ToString();
        }

        private void TbInvoNum_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbInvoNum.Text))
            {
                this.BackColor = Color.LightPink;
                btnPrint.Enabled = true;
                btnSave.Enabled = true;
           }
            else
            {
                this.BackColor = Color.LightGray;
                btnPrint.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUnitPrice.Text))
            {
                StockValues sv = new StockValues();
                decimal kk = sv.ProductTaxRate(prodidlocal, Convert.ToDecimal(tbUnitPrice.Text));
                decimal jj = sv.ProductBasicPrice(kk, Convert.ToDecimal(tbUnitPrice.Text));

                tbUnitBasicPrice.Text = (Decimal.Round(jj)).ToString();
                decimal yy = sv.ProductTaxAmount(Convert.ToDecimal(tbUnitBasicPrice.Text), Convert.ToDecimal(tbUnitPrice.Text));
                tbUnitTax.Text = (Decimal.Round(yy)).ToString();
            }
        }

        private void BtnAddUnit_Click(object sender, EventArgs e)
        {
          
            groupBox3.Enabled = false;
            groupBox1.Enabled = false;
            StockList stockList = new StockList();

            try
            {


                var proNme = ProdList.Single(y => y.ID == prodidlocal);
                stockList.Id = prodidlocal;
                stockList.Description = proNme.ProductName;
                stockList.Qty = (int)nupunits.Value;
                stockList.Unit = "Pices";
                stockList.Rate = Convert.ToDecimal(tbUnitRte.Text);
                stockList.BasicPrice = Decimal.Round(Convert.ToDecimal(tbUnitBasicPrice.Text));
                stockList.TaxAmount = Decimal.Round(Convert.ToDecimal(tbUnitTax.Text));
                stockList.ProductRate = Convert.ToDecimal(tbUnitPrice.Text);

                SelectionDisply.Add(stockList);
                dgvSelectedProd.DataSource = SelectionDisply.ToList();
                dgvSelectedProd.Columns["Id"].Visible = false;

              
            }
            catch { MessageBox.Show("try again"); }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
