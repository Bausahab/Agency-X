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
    public partial class UCaddProduct : UserControl
    {
        public event EventHandler<string> ProductAdded;
        Models.AgencyDbContext prodContext;
        int taxid;
        public UCaddProduct()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Data.Product pro = new Models.Data.Product();
                pro.ProductName = tbProdName.Text.Trim();
                pro.ProductSize = cbProdSize.Text.Trim();
                pro.HSN = tbHsn.Text;
                pro.TaxId = taxid;
                pro.UnitsCount = (int)nudUnitCount.Value;
                pro.Status = Models.Data.Status.Current;
                using (prodContext = new Models.AgencyDbContext())
                {
                    prodContext.PRODUCTS.Add(pro);
                    prodContext.SaveChanges();
                }
                ProductAdded?.Invoke(this, tbProdName.Text);
                this.Dispose();
            }
            catch { }
            
        }

        private void ComboBox1_DropDown(object sender, EventArgs e)
        {
            using (prodContext = new Models.AgencyDbContext())
            {
                comboBox1.DataSource = prodContext.GST.ToList();
                comboBox1.DisplayMember = "TaxPercent";
                comboBox1.ValueMember = "ID";
            }
        }

        private void ComboBox1_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                taxid = (int)comboBox1.SelectedValue;
            }
            catch
            {

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UCaddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
