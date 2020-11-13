namespace UI
{
    partial class FrmStock
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
            this.extendedTextBoxControl1 = new ExtendedTextBox.ExtendedTextBoxControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // extendedTextBoxControl1
            // 
            this.extendedTextBoxControl1.BoxText = "";
            this.extendedTextBoxControl1.ErrorMessage = null;
            this.extendedTextBoxControl1.isRequired = true;
            this.extendedTextBoxControl1.Location = new System.Drawing.Point(33, 23);
            this.extendedTextBoxControl1.Name = "extendedTextBoxControl1";
            this.extendedTextBoxControl1.NumbericTextBox = false;
            this.extendedTextBoxControl1.Size = new System.Drawing.Size(317, 20);
            this.extendedTextBoxControl1.TabIndex = 0;
            this.extendedTextBoxControl1.TextMode = ExtendedTextBox.ExtendedTextBoxControl.Modes.SingleLine;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.extendedTextBoxControl1);
            this.Name = "FrmStock";
            this.Text = "FrmStock";
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedTextBox.ExtendedTextBoxControl extendedTextBoxControl1;
        private System.Windows.Forms.Button button1;
    }
}