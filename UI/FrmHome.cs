using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            UCaddProduct hh = new UCaddProduct();
            tableLayoutPanel1.Controls.Add(hh,0,0);           
            hh.Show();
            hh.ProductAdded += Hh_ProductAdded;

        }

        private void Hh_ProductAdded(object sender, string e)
        {
            
            MessageBox.Show(e.ToString() + "\nAdded");
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void GSTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            UCgst uu = new UCgst();
            tableLayoutPanel1.Controls.Add(uu);
            uu.Show();
        }

        private void AllToolStripMenuItem_Click(object sender, EventArgs e)
        {

            tableLayoutPanel1.Controls.Clear();
            UCallProduct uu = new UCallProduct();
            tableLayoutPanel1.Controls.Add(uu);
            uu.Dock = DockStyle.Fill;
            uu.Show();
        }

        private void AddPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            UCpurchaseStock ps = new UCpurchaseStock();
            tableLayoutPanel1.Controls.Add(ps);
         
            ps.Dock = DockStyle.Fill;
           ps.Show();
        }

        private void UpdateSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            UCsaleStock ps = new UCsaleStock();
            tableLayoutPanel1.Controls.Add(ps);
            ps.Dock = DockStyle.Fill;
            ps.Show();
        }

       

        private void ApplicationFeatureListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BECOMPACTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void WhereHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
           UCwhouse ps = new UCwhouse();
            tableLayoutPanel1.Controls.Add(ps);
            ps.Dock = DockStyle.Fill;
            ps.Show();

        }
    }
}
