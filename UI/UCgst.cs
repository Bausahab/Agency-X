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
    public partial class UCgst : UserControl
    {
        Models.AgencyDbContext gstContext;
        int taxd = 0;
        public UCgst()
        {
            InitializeComponent();
        }

        private void UCgst_Load(object sender, EventArgs e)
        {
            using (gstContext = new Models.AgencyDbContext())
            {
                dataGridView1.DataSource = gstContext.GST.ToList();
                dataGridView1.Columns["ID"].Visible = false;

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Models.Data.Tax gst = new Models.Data.Tax();
            gst.TaxPercent = tbHsn.Text;
            gst.TaxValue = nudUnitCount.Value.ToString();
            using (gstContext = new Models.AgencyDbContext())
            {
                gstContext.GST.Add(gst);
                gstContext.SaveChanges();
                dataGridView1.DataSource = gstContext.GST.ToList();
                dataGridView1.Columns["ID"].Visible = false;
            }
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            taxd = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            button2.Text = "DELETE" + taxd.ToString();
           

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //correct this section..
            if(taxd!=0)
            {
                button2.BackColor = Color.Blue;
                button2.ForeColor = Color.Yellow;
                using (gstContext = new Models.AgencyDbContext())
                {
                    var selectTax = gstContext.GST.Single(p => p.ID == taxd);
                    gstContext.GST.Remove(selectTax);
                    gstContext.SaveChanges();
                    dataGridView1.DataSource = gstContext.GST.ToList();
                    dataGridView1.Columns["ID"].Visible = false;
                }
                taxd = 0;
                button2.Text = "Close";
                button2.BackColor = Color.Coral;
                button2.ForeColor = Color.Black;
            }
            else
            {
                this.Dispose();
            }
        }

        private void NudUnitCount_ValueChanged(object sender, EventArgs e)
        {
            tbHsn.Text =((int)nudUnitCount.Value).ToString();
        }
    }
}
