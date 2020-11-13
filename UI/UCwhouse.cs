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
    public partial class UCwhouse : UserControl
    {
        Models.AgencyDbContext StockContext;
        List<Models.Data.Product> ProdList = new List<Models.Data.Product>();
        List<Models.Data.Tax> gStList = new List<Models.Data.Tax>();
        List<Models.Data.Stock> actualStock = new List<Models.Data.Stock>();
        List<StockList> StockDisply = new List<StockList>();
        public UCwhouse()
        {
            InitializeComponent();
        }

        private void UCwhouse_Load(object sender, EventArgs e)
        {

            //var jook = ProdList.Select(b => new { b.ID, b.ProductName, b.ProductSize, b.UnitsCount }).SingleOrDefault(u=>u.ID == 1);
            //cbInvoiceType.DataSource = Enum.GetValues(typeof(Models.Data.ActionType));
            //cbInvoiceType.SelectedIndex = 0;
            using (StockContext = new Models.AgencyDbContext())
            {
                actualStock.AddRange(StockContext.INVENTORY.ToList());
            }
            //var datalist = (from y in AllProd.INVENTORY
            //                where y.ProductID.Equals(productID)
            //                select y).ToList();
        }

        private void CbInvoiceType_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (StockContext = new Models.AgencyDbContext())
            {
                dataGridView1.DataSource = StockContext.INVENTORY.ToList();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            using (StockContext = new Models.AgencyDbContext())
            {
                var datalist = (from y in StockContext.INVENTORY
                                where y.InvoiceNumber.Equals(textBox1.Text)
                                select y).ToList();

                dataGridView1.DataSource = datalist.ToList();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            using (StockContext = new Models.AgencyDbContext())
            {
                var datalist = (from y in StockContext.INVENTORY
                                where y.ActionType==Models.Data.ActionType.Sale
                                select y).ToList();

                dataGridView1.DataSource = datalist.ToList();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            using (StockContext = new Models.AgencyDbContext())
                {
                    var datalist = (from y in StockContext.INVENTORY
                                    where y.ActionType == Models.Data.ActionType.Purchase
                                    select y).ToList();

                    dataGridView1.DataSource = datalist.ToList();
                }
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if(groupBox3.Visible==true)
            {
                groupBox3.Visible = false;
                button7.Text = "Show Controls";
            }
            else
            {
                groupBox3.Visible = true;
                button7.Text = "Full Screen";
            }
          
            //tableLayoutPanel1.RowCount = 1;
        }
    }
}
