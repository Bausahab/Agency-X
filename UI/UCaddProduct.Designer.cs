namespace UI
{
    partial class UCaddProduct
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudUnitCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHsn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProdName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProdSize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitCount)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(72, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 30);
            this.button1.TabIndex = 25;
            this.button1.Text = "ADD NEW PRODUCT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(72, 273);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(189, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Activate This Product  Immediately";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "UNIT COUNT";
            // 
            // nudUnitCount
            // 
            this.nudUnitCount.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudUnitCount.Location = new System.Drawing.Point(16, 222);
            this.nudUnitCount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudUnitCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUnitCount.Name = "nudUnitCount";
            this.nudUnitCount.Size = new System.Drawing.Size(149, 45);
            this.nudUnitCount.TabIndex = 22;
            this.nudUnitCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudUnitCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "HSN";
            // 
            // tbHsn
            // 
            this.tbHsn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHsn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHsn.Location = new System.Drawing.Point(191, 225);
            this.tbHsn.Name = "tbHsn";
            this.tbHsn.Size = new System.Drawing.Size(129, 25);
            this.tbHsn.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "PRODUCT NAME";
            // 
            // tbProdName
            // 
            this.tbProdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProdName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProdName.Location = new System.Drawing.Point(16, 62);
            this.tbProdName.Name = "tbProdName";
            this.tbProdName.Size = new System.Drawing.Size(299, 25);
            this.tbProdName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "TAX PERCENTAGE";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(195, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 45);
            this.comboBox1.TabIndex = 53;
            this.comboBox1.DropDown += new System.EventHandler(this.ComboBox1_DropDown);
            this.comboBox1.DropDownClosed += new System.EventHandler(this.ComboBox1_DropDownClosed);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(313, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(19, 22);
            this.button2.TabIndex = 55;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "WEIGHT/SIZE";
            // 
            // cbProdSize
            // 
            this.cbProdSize.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdSize.FormattingEnabled = true;
            this.cbProdSize.Items.AddRange(new object[] {
            "25gm",
            "50gm",
            "75gm",
            "100gm\\",
            "200gm"});
            this.cbProdSize.Location = new System.Drawing.Point(16, 126);
            this.cbProdSize.Name = "cbProdSize";
            this.cbProdSize.Size = new System.Drawing.Size(149, 40);
            this.cbProdSize.TabIndex = 58;
            // 
            // UCaddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.cbProdSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudUnitCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHsn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProdName);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UCaddProduct";
            this.Size = new System.Drawing.Size(337, 348);
            this.Load += new System.EventHandler(this.UCaddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudUnitCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHsn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProdName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProdSize;
    }
}
