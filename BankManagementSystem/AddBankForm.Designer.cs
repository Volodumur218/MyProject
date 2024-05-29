namespace BankManagementSystem
{
    partial class AddBankForm
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
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtBankStatus = new System.Windows.Forms.TextBox();
            this.txtMFO = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBankCode
            // 
            this.txtBankCode.Location = new System.Drawing.Point(51, 12);
            this.txtBankCode.Name = "txtBankCode";
            this.txtBankCode.Size = new System.Drawing.Size(200, 26);
            this.txtBankCode.TabIndex = 0;
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(51, 44);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(200, 26);
            this.txtBankName.TabIndex = 1;
            // 
            // txtBankStatus
            // 
            this.txtBankStatus.Location = new System.Drawing.Point(51, 76);
            this.txtBankStatus.Name = "txtBankStatus";
            this.txtBankStatus.Size = new System.Drawing.Size(200, 26);
            this.txtBankStatus.TabIndex = 2;
            // 
            // txtMFO
            // 
            this.txtMFO.Location = new System.Drawing.Point(51, 108);
            this.txtMFO.Name = "txtMFO";
            this.txtMFO.Size = new System.Drawing.Size(200, 26);
            this.txtMFO.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(108, 163);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 50);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddBankForm
            // 
            this.ClientSize = new System.Drawing.Size(540, 289);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMFO);
            this.Controls.Add(this.txtBankStatus);
            this.Controls.Add(this.txtBankName);
            this.Controls.Add(this.txtBankCode);
            this.Name = "AddBankForm";
            this.Text = "Add Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBankCode;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.TextBox txtBankStatus;
        private System.Windows.Forms.TextBox txtMFO;
        private System.Windows.Forms.Button btnSave;
    }
}


