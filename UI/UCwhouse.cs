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
        public UCwhouse()
        {
            InitializeComponent();
        }

        private void UCwhouse_Load(object sender, EventArgs e)
        {
            //cbInvoiceType.DataSource = Enum.GetValues(typeof(Models.Data.ActionType));
            //cbInvoiceType.SelectedIndex = 0;
            using (StockContext = new Models.AgencyDbContext())
            {
                dataGridView1.DataSource = StockContext.INVENTORY.ToList();
            }
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
    }
}
