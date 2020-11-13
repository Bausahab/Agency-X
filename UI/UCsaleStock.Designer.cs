namespace UI
{
    partial class UCsaleStock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbTransType = new System.Windows.Forms.ComboBox();
            this.dgvSelectedProd = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cbInvoiceType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.tbInvoNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInvoiceTo = new System.Windows.Forms.TextBox();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.nupunits = new System.Windows.Forms.NumericUpDown();
            this.tbGSTN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbUnitTax = new System.Windows.Forms.TextBox();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUnitBasicPrice = new System.Windows.Forms.TextBox();
            this.btnCalUnit = new System.Windows.Forms.Button();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbUnitRte = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBoxTax = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCalBox = new System.Windows.Forms.Button();
            this.tbBoxBasicPrice = new System.Windows.Forms.TextBox();
            this.btnAddBox = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.nupBoxes = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.tbBoxRte = new System.Windows.Forms.TextBox();
            this.tbBoxPrice = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupunits)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBoxes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.cbTransType);
            this.panel2.Controls.Add(this.dgvSelectedProd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.cbInvoiceType);
            this.panel2.Location = new System.Drawing.Point(671, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 470);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 34);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "SAVEnEXIT";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // cbTransType
            // 
            this.cbTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTransType.FormattingEnabled = true;
            this.cbTransType.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "DigitalPaymentService"});
            this.cbTransType.Location = new System.Drawing.Point(132, 35);
            this.cbTransType.Name = "cbTransType";
            this.cbTransType.Size = new System.Drawing.Size(149, 21);
            this.cbTransType.TabIndex = 54;
            // 
            // dgvSelectedProd
            // 
            this.dgvSelectedProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSelectedProd.BackgroundColor = System.Drawing.Color.White;
            this.dgvSelectedProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedProd.Location = new System.Drawing.Point(3, 62);
            this.dgvSelectedProd.Name = "dgvSelectedProd";
            this.dgvSelectedProd.Size = new System.Drawing.Size(337, 363);
            this.dgvSelectedProd.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Transition Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Invoice Type";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.AutoSize = true;
            this.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(184, 431);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(156, 34);
            this.btnPrint.TabIndex = 50;
            this.btnPrint.Text = "PRINT INVOICE";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // cbInvoiceType
            // 
            this.cbInvoiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInvoiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbInvoiceType.FormattingEnabled = true;
            this.cbInvoiceType.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "DigitalPaymentService"});
            this.cbInvoiceType.Location = new System.Drawing.Point(132, 9);
            this.cbInvoiceType.Name = "cbInvoiceType";
            this.cbInvoiceType.Size = new System.Drawing.Size(149, 21);
            this.cbInvoiceType.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "INVOICE  NUMBER";
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaleDate.Location = new System.Drawing.Point(143, 14);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(141, 29);
            this.dtpSaleDate.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "INVOICE DATE";
            // 
            // tbInvoNum
            // 
            this.tbInvoNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInvoNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvoNum.Location = new System.Drawing.Point(143, 63);
            this.tbInvoNum.Name = "tbInvoNum";
            this.tbInvoNum.Size = new System.Drawing.Size(157, 25);
            this.tbInvoNum.TabIndex = 36;
            this.tbInvoNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbInvoNum.TextChanged += new System.EventHandler(this.TbInvoNum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "INVOICE TO:";
            // 
            // tbInvoiceTo
            // 
            this.tbInvoiceTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInvoiceTo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvoiceTo.Location = new System.Drawing.Point(313, 63);
            this.tbInvoiceTo.Multiline = true;
            this.tbInvoiceTo.Name = "tbInvoiceTo";
            this.tbInvoiceTo.Size = new System.Drawing.Size(183, 64);
            this.tbInvoiceTo.TabIndex = 51;
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProd.BackgroundColor = System.Drawing.Color.White;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(16, 137);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProd.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProd.Size = new System.Drawing.Size(324, 399);
            this.dgvProd.TabIndex = 54;
            this.dgvProd.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView2_RowHeaderMouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(50, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 50;
            this.label13.Text = "UNITS";
            // 
            // nupunits
            // 
            this.nupunits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupunits.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupunits.InterceptArrowKeys = false;
            this.nupunits.Location = new System.Drawing.Point(14, 104);
            this.nupunits.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupunits.Name = "nupunits";
            this.nupunits.Size = new System.Drawing.Size(135, 45);
            this.nupunits.TabIndex = 49;
            this.nupunits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupunits.ValueChanged += new System.EventHandler(this.Nupunits_ValueChanged);
            // 
            // tbGSTN
            // 
            this.tbGSTN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGSTN.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGSTN.Location = new System.Drawing.Point(143, 102);
            this.tbGSTN.Name = "tbGSTN";
            this.tbGSTN.Size = new System.Drawing.Size(157, 25);
            this.tbGSTN.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "GSTN:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbUnitTax);
            this.groupBox3.Controls.Add(this.tbUnitPrice);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbUnitBasicPrice);
            this.groupBox3.Controls.Add(this.btnCalUnit);
            this.groupBox3.Controls.Add(this.btnAddUnit);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.tbUnitRte);
            this.groupBox3.Controls.Add(this.nupunits);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(502, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 395);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PICES/UNITS";
            // 
            // tbUnitTax
            // 
            this.tbUnitTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUnitTax.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnitTax.Location = new System.Drawing.Point(35, 310);
            this.tbUnitTax.Name = "tbUnitTax";
            this.tbUnitTax.Size = new System.Drawing.Size(94, 32);
            this.tbUnitTax.TabIndex = 61;
            this.tbUnitTax.Text = "0.00";
            this.tbUnitTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUnitPrice.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnitPrice.Location = new System.Drawing.Point(19, 175);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(126, 25);
            this.tbUnitPrice.TabIndex = 58;
            this.tbUnitPrice.Text = "0.00";
            this.tbUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 62;
            this.label9.Text = "TAX AMOUNT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = " RATE";
            // 
            // tbUnitBasicPrice
            // 
            this.tbUnitBasicPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUnitBasicPrice.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnitBasicPrice.Location = new System.Drawing.Point(35, 252);
            this.tbUnitBasicPrice.Name = "tbUnitBasicPrice";
            this.tbUnitBasicPrice.Size = new System.Drawing.Size(94, 32);
            this.tbUnitBasicPrice.TabIndex = 59;
            this.tbUnitBasicPrice.Text = "0.00";
            this.tbUnitBasicPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalUnit
            // 
            this.btnCalUnit.AutoSize = true;
            this.btnCalUnit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalUnit.Location = new System.Drawing.Point(30, 203);
            this.btnCalUnit.Name = "btnCalUnit";
            this.btnCalUnit.Size = new System.Drawing.Size(100, 23);
            this.btnCalUnit.TabIndex = 56;
            this.btnCalUnit.Text = "Calculate Amount";
            this.btnCalUnit.UseVisualStyleBackColor = true;
            this.btnCalUnit.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.AutoSize = true;
            this.btnAddUnit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUnit.Location = new System.Drawing.Point(32, 359);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(97, 26);
            this.btnAddUnit.TabIndex = 58;
            this.btnAddUnit.Text = "ADD UNIT(s)";
            this.btnAddUnit.UseVisualStyleBackColor = true;
            this.btnAddUnit.Click += new System.EventHandler(this.BtnAddUnit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "UNIT RATE";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(37, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 20);
            this.label16.TabIndex = 60;
            this.label16.Text = "BASIC PRICE";
            // 
            // tbUnitRte
            // 
            this.tbUnitRte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUnitRte.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnitRte.Location = new System.Drawing.Point(14, 46);
            this.tbUnitRte.Name = "tbUnitRte";
            this.tbUnitRte.Size = new System.Drawing.Size(135, 32);
            this.tbUnitRte.TabIndex = 51;
            this.tbUnitRte.Text = "0.00";
            this.tbUnitRte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBoxTax);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.btnCalBox);
            this.groupBox1.Controls.Add(this.tbBoxBasicPrice);
            this.groupBox1.Controls.Add(this.btnAddBox);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.nupBoxes);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.tbBoxRte);
            this.groupBox1.Controls.Add(this.tbBoxPrice);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(346, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 395);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BOX/PACK";
            // 
            // tbBoxTax
            // 
            this.tbBoxTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBoxTax.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBoxTax.Location = new System.Drawing.Point(24, 314);
            this.tbBoxTax.Name = "tbBoxTax";
            this.tbBoxTax.Size = new System.Drawing.Size(94, 32);
            this.tbBoxTax.TabIndex = 56;
            this.tbBoxTax.Text = "0.00";
            this.tbBoxTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(23, 291);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 20);
            this.label17.TabIndex = 57;
            this.label17.Text = "TAX AMOUNT";
            // 
            // btnCalBox
            // 
            this.btnCalBox.AutoSize = true;
            this.btnCalBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalBox.Location = new System.Drawing.Point(24, 203);
            this.btnCalBox.Name = "btnCalBox";
            this.btnCalBox.Size = new System.Drawing.Size(100, 23);
            this.btnCalBox.TabIndex = 56;
            this.btnCalBox.Text = "Calculate Amount";
            this.btnCalBox.UseVisualStyleBackColor = true;
            this.btnCalBox.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbBoxBasicPrice
            // 
            this.tbBoxBasicPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBoxBasicPrice.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBoxBasicPrice.Location = new System.Drawing.Point(24, 256);
            this.tbBoxBasicPrice.Name = "tbBoxBasicPrice";
            this.tbBoxBasicPrice.Size = new System.Drawing.Size(94, 32);
            this.tbBoxBasicPrice.TabIndex = 54;
            this.tbBoxBasicPrice.Text = "0.00";
            this.tbBoxBasicPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddBox
            // 
            this.btnAddBox.AutoSize = true;
            this.btnAddBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBox.Location = new System.Drawing.Point(24, 359);
            this.btnAddBox.Name = "btnAddBox";
            this.btnAddBox.Size = new System.Drawing.Size(92, 26);
            this.btnAddBox.TabIndex = 44;
            this.btnAddBox.Text = "ADD BOX(s)";
            this.btnAddBox.UseVisualStyleBackColor = true;
            this.btnAddBox.Click += new System.EventHandler(this.BtnAddToInvoice_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(33, 81);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 20);
            this.label18.TabIndex = 48;
            this.label18.Text = "BOXES";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(26, 233);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 20);
            this.label19.TabIndex = 55;
            this.label19.Text = "BASIC PRICE";
            // 
            // nupBoxes
            // 
            this.nupBoxes.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupBoxes.Location = new System.Drawing.Point(8, 104);
            this.nupBoxes.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupBoxes.Name = "nupBoxes";
            this.nupBoxes.Size = new System.Drawing.Size(135, 45);
            this.nupBoxes.TabIndex = 47;
            this.nupBoxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupBoxes.ValueChanged += new System.EventHandler(this.Nupqty_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(20, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 20);
            this.label20.TabIndex = 52;
            this.label20.Text = "BOX/PACK RATE";
            this.label20.TextChanged += new System.EventHandler(this.TbProdRate_TextChanged);
            // 
            // tbBoxRte
            // 
            this.tbBoxRte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBoxRte.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBoxRte.Location = new System.Drawing.Point(8, 46);
            this.tbBoxRte.Name = "tbBoxRte";
            this.tbBoxRte.Size = new System.Drawing.Size(135, 32);
            this.tbBoxRte.TabIndex = 51;
            this.tbBoxRte.Text = "0.00";
            this.tbBoxRte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBoxRte.TextChanged += new System.EventHandler(this.TbProdRate_TextChanged);
            // 
            // tbBoxPrice
            // 
            this.tbBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBoxPrice.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBoxPrice.Location = new System.Drawing.Point(14, 175);
            this.tbBoxPrice.Name = "tbBoxPrice";
            this.tbBoxPrice.Size = new System.Drawing.Size(126, 25);
            this.tbBoxPrice.TabIndex = 53;
            this.tbBoxPrice.Text = "0.00";
            this.tbBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBoxPrice.Leave += new System.EventHandler(this.TbRte_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(45, 152);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 20);
            this.label21.TabIndex = 46;
            this.label21.Text = " RATE";
            // 
            // UCsaleStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbGSTN);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInvoiceTo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpSaleDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbInvoNum);
            this.MinimumSize = new System.Drawing.Size(970, 440);
            this.Name = "UCsaleStock";
            this.Size = new System.Drawing.Size(1022, 543);
            this.Load += new System.EventHandler(this.UCsaleStock_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupunits)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBoxes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvSelectedProd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbInvoNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInvoiceTo;
        private System.Windows.Forms.ComboBox cbInvoiceType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nupunits;
        private System.Windows.Forms.ComboBox cbTransType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGSTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbUnitPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUnitRte;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbUnitTax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUnitBasicPrice;
        private System.Windows.Forms.Button btnAddUnit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBoxTax;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCalBox;
        private System.Windows.Forms.TextBox tbBoxBasicPrice;
        private System.Windows.Forms.Button btnAddBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown nupBoxes;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbBoxRte;
        private System.Windows.Forms.TextBox tbBoxPrice;
        private System.Windows.Forms.Label label21;
    }
}
