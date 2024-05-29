namespace BankManagementSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtBankCode = new System.Windows.Forms.TextBox();
            this.btnGetBankInfo = new System.Windows.Forms.Button();
            this.btnAddBank = new System.Windows.Forms.Button();
            this.lstBankInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBankCode
            // 
            this.txtBankCode.Location = new System.Drawing.Point(429, 28);
            this.txtBankCode.Name = "txtBankCode";
            this.txtBankCode.Size = new System.Drawing.Size(182, 26);
            this.txtBankCode.TabIndex = 0;
            //this.txtBankCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnGetBankInfo
            // 
            this.btnGetBankInfo.Location = new System.Drawing.Point(273, 89);
            this.btnGetBankInfo.Name = "btnGetBankInfo";
            this.btnGetBankInfo.Size = new System.Drawing.Size(146, 39);
            this.btnGetBankInfo.TabIndex = 1;
            this.btnGetBankInfo.Text = "Get Info";
            this.btnGetBankInfo.UseVisualStyleBackColor = true;
            this.btnGetBankInfo.Click += new System.EventHandler(this.btnGetBankInfo_Click);
            // 
            // btnAddBank
            // 
            this.btnAddBank.Location = new System.Drawing.Point(273, 162);
            this.btnAddBank.Name = "btnAddBank";
            this.btnAddBank.Size = new System.Drawing.Size(146, 37);
            this.btnAddBank.TabIndex = 2;
            this.btnAddBank.Text = "Add Bank";
            this.btnAddBank.UseVisualStyleBackColor = true;
            this.btnAddBank.Click += new System.EventHandler(this.btnAddBank_Click);
            // 
            // lstBankInfo
            // 
            this.lstBankInfo.FormattingEnabled = true;
            this.lstBankInfo.ItemHeight = 20;
            this.lstBankInfo.Location = new System.Drawing.Point(44, 56);
            this.lstBankInfo.Name = "lstBankInfo";
            this.lstBankInfo.Size = new System.Drawing.Size(120, 84);
            this.lstBankInfo.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 467);
            this.Controls.Add(this.lstBankInfo);
            this.Controls.Add(this.btnAddBank);
            this.Controls.Add(this.btnGetBankInfo);
            this.Controls.Add(this.txtBankCode);
            this.Name = "MainForm";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtBankCode;
        private System.Windows.Forms.Button btnGetBankInfo;
        private System.Windows.Forms.Button btnAddBank;
        private System.Windows.Forms.ListBox lstBankInfo;
    }
}


