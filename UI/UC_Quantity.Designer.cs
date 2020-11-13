namespace UI
{
    partial class UC_Quantity
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbBoxQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUnitQty = new System.Windows.Forms.TextBox();
            this.lblProdName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Box Quantity";
            // 
            // tbBoxQty
            // 
            this.tbBoxQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBoxQty.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBoxQty.Location = new System.Drawing.Point(156, 80);
            this.tbBoxQty.Name = "tbBoxQty";
            this.tbBoxQty.Size = new System.Drawing.Size(123, 25);
            this.tbBoxQty.TabIndex = 42;
            this.tbBoxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Unit Quantity";
            // 
            // tbUnitQty
            // 
            this.tbUnitQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUnitQty.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnitQty.Location = new System.Drawing.Point(155, 141);
            this.tbUnitQty.Name = "tbUnitQty";
            this.tbUnitQty.Size = new System.Drawing.Size(124, 25);
            this.tbUnitQty.TabIndex = 44;
            this.tbUnitQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.ForeColor = System.Drawing.Color.White;
            this.lblProdName.Location = new System.Drawing.Point(13, 21);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(315, 29);
            this.lblProdName.TabIndex = 42;
            this.lblProdName.Text = "PRODUCT NAME+DESCRIPTION";
            this.lblProdName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(504, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(19, 22);
            this.button2.TabIndex = 56;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // UC_Quantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbBoxQty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUnitQty);
            this.Name = "UC_Quantity";
            this.Size = new System.Drawing.Size(529, 215);
            this.Load += new System.EventHandler(this.UC_Quantity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBoxQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUnitQty;
    }
}
