namespace UI
{
    partial class Frminvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frminvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reszeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.pnlReceptHead = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tbBillTo = new System.Windows.Forms.TextBox();
            this.tbRecptDt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRecptNum = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tbShipTo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelRecHead = new System.Windows.Forms.Panel();
            this.lblstate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlReceptFoot = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBasicTtl = new System.Windows.Forms.TextBox();
            this.tbGrandTtl = new System.Windows.Forms.TextBox();
            this.tbTaxTtl = new System.Windows.Forms.TextBox();
            this.datagridReceptItm = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.pnlReceptHead.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelRecHead.SuspendLayout();
            this.pnlReceptFoot.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridReceptItm)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reszeToolStripMenuItem,
            this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reszeToolStripMenuItem
            // 
            this.reszeToolStripMenuItem.Name = "reszeToolStripMenuItem";
            this.reszeToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.reszeToolStripMenuItem.Text = "Resize";
            this.reszeToolStripMenuItem.Click += new System.EventHandler(this.ReszeToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TAX INVOICE";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(0, 33);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(599, 45);
            this.textBox6.TabIndex = 2;
            this.textBox6.Text = "SARNATH-VARANASI\r\nGSTN:09ADIFS6223L1ZM";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlReceptHead
            // 
            this.pnlReceptHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReceptHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReceptHead.Controls.Add(this.textBox6);
            this.pnlReceptHead.Controls.Add(this.textBox5);
            this.pnlReceptHead.Location = new System.Drawing.Point(0, 47);
            this.pnlReceptHead.Name = "pnlReceptHead";
            this.pnlReceptHead.Size = new System.Drawing.Size(601, 80);
            this.pnlReceptHead.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(0, 0);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(599, 27);
            this.textBox5.TabIndex = 1;
            this.textBox5.Text = "SHARMA-AGENCIES";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbBillTo
            // 
            this.tbBillTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBillTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBillTo.Location = new System.Drawing.Point(3, 16);
            this.tbBillTo.Multiline = true;
            this.tbBillTo.Name = "tbBillTo";
            this.tbBillTo.Size = new System.Drawing.Size(197, 60);
            this.tbBillTo.TabIndex = 0;
            // 
            // tbRecptDt
            // 
            this.tbRecptDt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRecptDt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRecptDt.Location = new System.Drawing.Point(4, 39);
            this.tbRecptDt.Multiline = true;
            this.tbRecptDt.Name = "tbRecptDt";
            this.tbRecptDt.Size = new System.Drawing.Size(156, 28);
            this.tbRecptDt.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBillTo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill To:";
            // 
            // tbRecptNum
            // 
            this.tbRecptNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRecptNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRecptNum.Location = new System.Drawing.Point(4, 4);
            this.tbRecptNum.Multiline = true;
            this.tbRecptNum.Name = "tbRecptNum";
            this.tbRecptNum.Size = new System.Drawing.Size(156, 28);
            this.tbRecptNum.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tbRecptDt, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbRecptNum, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(211, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(164, 71);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tbShipTo
            // 
            this.tbShipTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbShipTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbShipTo.Location = new System.Drawing.Point(3, 16);
            this.tbShipTo.Multiline = true;
            this.tbShipTo.Name = "tbShipTo";
            this.tbShipTo.Size = new System.Drawing.Size(194, 52);
            this.tbShipTo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbShipTo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 71);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Place Of Supply";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.03597F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.96403F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(214, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(379, 79);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.19669F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.80331F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(597, 87);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelRecHead
            // 
            this.panelRecHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRecHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecHead.Controls.Add(this.tableLayoutPanel1);
            this.panelRecHead.Location = new System.Drawing.Point(1, 133);
            this.panelRecHead.Name = "panelRecHead";
            this.panelRecHead.Size = new System.Drawing.Size(599, 89);
            this.panelRecHead.TabIndex = 4;
            // 
            // lblstate
            // 
            this.lblstate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblstate.AutoSize = true;
            this.lblstate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstate.Location = new System.Drawing.Point(476, 25);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(113, 20);
            this.lblstate.TabIndex = 4;
            this.lblstate.Text = "RECEIPT STATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 5);
            this.label2.TabIndex = 3;
            this.label2.Text = "By:SHARMA-AGENCIES((ManishRajSingh@9452323247))";
            // 
            // pnlReceptFoot
            // 
            this.pnlReceptFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReceptFoot.Controls.Add(this.tableLayoutPanel4);
            this.pnlReceptFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlReceptFoot.Location = new System.Drawing.Point(0, 403);
            this.pnlReceptFoot.Name = "pnlReceptFoot";
            this.pnlReceptFoot.Size = new System.Drawing.Size(601, 82);
            this.pnlReceptFoot.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.47934F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.19008F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbBasicTtl, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbGrandTtl, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbTaxTtl, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(599, 80);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "TOTAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 80);
            this.label3.TabIndex = 1;
            this.label3.Text = "Amount Chargeable (in words)\t   \r\n...................\t   \r\nCompany\'s PAN: ADIFS62" +
    "23L\r\nNote-Please make cheques in favor of \"SHARMA-AGENCIES\"";
            // 
            // tbBasicTtl
            // 
            this.tbBasicTtl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbBasicTtl.Location = new System.Drawing.Point(241, 3);
            this.tbBasicTtl.Name = "tbBasicTtl";
            this.tbBasicTtl.Size = new System.Drawing.Size(114, 20);
            this.tbBasicTtl.TabIndex = 6;
            // 
            // tbGrandTtl
            // 
            this.tbGrandTtl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbGrandTtl.Location = new System.Drawing.Point(481, 3);
            this.tbGrandTtl.Name = "tbGrandTtl";
            this.tbGrandTtl.Size = new System.Drawing.Size(115, 20);
            this.tbGrandTtl.TabIndex = 8;
            // 
            // tbTaxTtl
            // 
            this.tbTaxTtl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTaxTtl.Location = new System.Drawing.Point(361, 3);
            this.tbTaxTtl.Name = "tbTaxTtl";
            this.tbTaxTtl.Size = new System.Drawing.Size(114, 20);
            this.tbTaxTtl.TabIndex = 7;
            // 
            // datagridReceptItm
            // 
            this.datagridReceptItm.AllowUserToAddRows = false;
            this.datagridReceptItm.AllowUserToDeleteRows = false;
            this.datagridReceptItm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridReceptItm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridReceptItm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridReceptItm.BackgroundColor = System.Drawing.Color.White;
            this.datagridReceptItm.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridReceptItm.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.datagridReceptItm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridReceptItm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridReceptItm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridReceptItm.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridReceptItm.EnableHeadersVisualStyles = false;
            this.datagridReceptItm.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datagridReceptItm.Location = new System.Drawing.Point(1, 227);
            this.datagridReceptItm.MultiSelect = false;
            this.datagridReceptItm.Name = "datagridReceptItm";
            this.datagridReceptItm.ReadOnly = true;
            this.datagridReceptItm.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagridReceptItm.RowHeadersVisible = false;
            this.datagridReceptItm.Size = new System.Drawing.Size(599, 179);
            this.datagridReceptItm.TabIndex = 6;
            // 
            // Frminvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 490);
            this.Controls.Add(this.datagridReceptItm);
            this.Controls.Add(this.pnlReceptFoot);
            this.Controls.Add(this.panelRecHead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblstate);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlReceptHead);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frminvoice";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frminvoice_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlReceptHead.ResumeLayout(false);
            this.pnlReceptHead.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelRecHead.ResumeLayout(false);
            this.pnlReceptFoot.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridReceptItm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reszeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel pnlReceptHead;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tbBillTo;
        private System.Windows.Forms.TextBox tbRecptDt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbRecptNum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tbShipTo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelRecHead;
        private System.Windows.Forms.Label lblstate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlReceptFoot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBasicTtl;
        private System.Windows.Forms.TextBox tbGrandTtl;
        private System.Windows.Forms.TextBox tbTaxTtl;
        private System.Windows.Forms.DataGridView datagridReceptItm;
    }
}