using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;


namespace UI
{
    
   
    public partial class Frminvoice : Form
    {
        Models.Data.InvoiceItems Stocklcl;
        List<StockList> invoItm;

        private Bitmap memoryImage;
        public Frminvoice()
        {
            InitializeComponent();
            Stocklcl = new Models.Data.InvoiceItems();
            invoItm = new List<StockList>();

        }
        public Frminvoice(Models.Data.InvoiceItems ii, List<StockList> InvoiceItems):this()
        {
            Stocklcl = ii;
            invoItm = InvoiceItems;

        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

        private void PrintScreen()
        {      
        
            Graphics mygraphics = this.CreateGraphics();
            int nWidth = printDocument1.PrinterSettings.DefaultPageSettings.PaperSize.Width;
            int nHeight = printDocument1.PrinterSettings.DefaultPageSettings.PaperSize.Height;
            Size si = this.Size;
            memoryImage = new Bitmap(si.Width, si.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            mygraphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            mygraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;

            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);



        }
        private void Frminvoice_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            datagridReceptItm.DataSource = invoItm.ToList();
            datagridReceptItm.Columns["UnitsObtained"].Visible = false;
            datagridReceptItm.Columns["Id"].Visible = false;
            //  datagridReceptItm.Columns[]
            lblstate.Text = Stocklcl.InvoiceState.ToString();
            tbBillTo.Text = Stocklcl.INVOICEPERSON;
            tbShipTo.Text = Stocklcl.INVOICEPERSON;
            tbRecptNum.Text = Stocklcl.RECEIPT_NO;
            tbRecptDt.Text = Stocklcl.DATED;
            tbBasicTtl.Text = invoItm.Sum(p => p.ProductRate).ToString();
            tbTaxTtl.Text = invoItm.Sum(u => u.BasicPrice).ToString();
            tbGrandTtl.Text = invoItm.Sum(t => t.TaxAmount).ToString();
            //get all product of invoice into a list;
        }

        private void ReszeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                

        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            PrintScreen();
            
            printDocument1.Print();
        }
    }
}
