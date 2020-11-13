namespace UI
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gSTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whereHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.businessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationFeatureListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featureMissingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFeatureRequiredListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bECOMPACTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.contactsToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.settingsToolStripMenuItem1,
            this.bECOMPACTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.allToolStripMenuItem,
            this.gSTToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(108, 27);
            this.productsToolStripMenuItem.Text = "&Products";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 28);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(123, 28);
            this.allToolStripMenuItem.Text = "&All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.AllToolStripMenuItem_Click);
            // 
            // gSTToolStripMenuItem
            // 
            this.gSTToolStripMenuItem.Name = "gSTToolStripMenuItem";
            this.gSTToolStripMenuItem.Size = new System.Drawing.Size(123, 28);
            this.gSTToolStripMenuItem.Text = "GST";
            this.gSTToolStripMenuItem.Click += new System.EventHandler(this.GSTToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPurchaseToolStripMenuItem,
            this.updateSaleToolStripMenuItem,
            this.whereHouseToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(75, 27);
            this.stockToolStripMenuItem.Text = "&Stock";
            // 
            // addPurchaseToolStripMenuItem
            // 
            this.addPurchaseToolStripMenuItem.Name = "addPurchaseToolStripMenuItem";
            this.addPurchaseToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.addPurchaseToolStripMenuItem.Text = "&Add(Purchase)";
            this.addPurchaseToolStripMenuItem.Click += new System.EventHandler(this.AddPurchaseToolStripMenuItem_Click);
            // 
            // updateSaleToolStripMenuItem
            // 
            this.updateSaleToolStripMenuItem.Name = "updateSaleToolStripMenuItem";
            this.updateSaleToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.updateSaleToolStripMenuItem.Text = "&Update(Sale)";
            this.updateSaleToolStripMenuItem.Click += new System.EventHandler(this.UpdateSaleToolStripMenuItem_Click);
            // 
            // whereHouseToolStripMenuItem
            // 
            this.whereHouseToolStripMenuItem.Name = "whereHouseToolStripMenuItem";
            this.whereHouseToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.whereHouseToolStripMenuItem.Text = "&Warehouse";
            this.whereHouseToolStripMenuItem.Click += new System.EventHandler(this.WhereHouseToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(93, 27);
            this.invoiceToolStripMenuItem.Text = "&Invoice";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(171, 28);
            this.generateToolStripMenuItem.Text = "&Generate";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(171, 28);
            this.detailsToolStripMenuItem.Text = "&Details";
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billersToolStripMenuItem,
            this.employeToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.businessToolStripMenuItem});
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(108, 27);
            this.contactsToolStripMenuItem.Text = "&Contacts";
            // 
            // billersToolStripMenuItem
            // 
            this.billersToolStripMenuItem.Name = "billersToolStripMenuItem";
            this.billersToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.billersToolStripMenuItem.Text = "&Billers";
            // 
            // employeToolStripMenuItem
            // 
            this.employeToolStripMenuItem.Name = "employeToolStripMenuItem";
            this.employeToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.employeToolStripMenuItem.Text = "&Employe";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.customersToolStripMenuItem.Text = "&Customers";
            // 
            // businessToolStripMenuItem
            // 
            this.businessToolStripMenuItem.Name = "businessToolStripMenuItem";
            this.businessToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.businessToolStripMenuItem.Text = "&Business";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.accountToolStripMenuItem.Text = "&Account";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationSettingsToolStripMenuItem,
            this.applicationFeatureListToolStripMenuItem,
            this.featureMissingListToolStripMenuItem,
            this.newFeatureRequiredListToolStripMenuItem,
            this.aboutApplicationToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.settingsToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(92, 27);
            this.settingsToolStripMenuItem1.Text = "Age&ncy";
            // 
            // applicationSettingsToolStripMenuItem
            // 
            this.applicationSettingsToolStripMenuItem.Name = "applicationSettingsToolStripMenuItem";
            this.applicationSettingsToolStripMenuItem.Size = new System.Drawing.Size(348, 28);
            this.applicationSettingsToolStripMenuItem.Text = "Application Settings";
            // 
            // applicationFeatureListToolStripMenuItem
            // 
            this.applicationFeatureListToolStripMenuItem.Name = "applicationFeatureListToolStripMenuItem";
            this.applicationFeatureListToolStripMenuItem.Size = new System.Drawing.Size(348, 28);
            this.applicationFeatureListToolStripMenuItem.Text = "&CheckList";
            this.applicationFeatureListToolStripMenuItem.Click += new System.EventHandler(this.ApplicationFeatureListToolStripMenuItem_Click);
            // 
            // featureMissingListToolStripMenuItem
            // 
            this.featureMissingListToolStripMenuItem.Name = "featureMissingListToolStripMenuItem";
            this.featureMissingListToolStripMenuItem.Size = new System.Drawing.Size(348, 28);
            this.featureMissingListToolStripMenuItem.Text = "&FeatureMissing List";
            // 
            // newFeatureRequiredListToolStripMenuItem
            // 
            this.newFeatureRequiredListToolStripMenuItem.Name = "newFeatureRequiredListToolStripMenuItem";
            this.newFeatureRequiredListToolStripMenuItem.Size = new System.Drawing.Size(348, 28);
            this.newFeatureRequiredListToolStripMenuItem.Text = "New Feature Required List";
            // 
            // aboutApplicationToolStripMenuItem
            // 
            this.aboutApplicationToolStripMenuItem.Name = "aboutApplicationToolStripMenuItem";
            this.aboutApplicationToolStripMenuItem.Size = new System.Drawing.Size(348, 28);
            this.aboutApplicationToolStripMenuItem.Text = "About Application";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(348, 28);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(348, 28);
            this.exitToolStripMenuItem.Text = "Exit!!!";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // bECOMPACTToolStripMenuItem
            // 
            this.bECOMPACTToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.bECOMPACTToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bECOMPACTToolStripMenuItem.Name = "bECOMPACTToolStripMenuItem";
            this.bECOMPACTToolStripMenuItem.Size = new System.Drawing.Size(130, 27);
            this.bECOMPACTToolStripMenuItem.Text = "COMPACT";
            this.bECOMPACTToolStripMenuItem.Click += new System.EventHandler(this.BECOMPACTToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 389);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(797, 443);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "SHARMA-AGENCIES, SARNATH-VARANASI";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem businessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whereHouseToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem gSTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem applicationFeatureListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featureMissingListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFeatureRequiredListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bECOMPACTToolStripMenuItem;
    }
}

