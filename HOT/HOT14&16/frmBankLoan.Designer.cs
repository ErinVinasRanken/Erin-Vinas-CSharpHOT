namespace HOT14_16
{
    partial class frmBankLoan
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
            this.gbCreateLoan = new System.Windows.Forms.GroupBox();
            this.gbManageLoan = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.radShortTerm = new System.Windows.Forms.RadioButton();
            this.radLongTerm = new System.Windows.Forms.RadioButton();
            this.btnCreateLoan = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblNameResults = new System.Windows.Forms.Label();
            this.lblLoanTypeResults = new System.Windows.Forms.Label();
            this.lblAmountResults = new System.Windows.Forms.Label();
            this.lblCurrentResults = new System.Windows.Forms.Label();
            this.lblDueResults = new System.Windows.Forms.Label();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbCreateLoan.SuspendLayout();
            this.gbManageLoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCreateLoan
            // 
            this.gbCreateLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbCreateLoan.Controls.Add(this.btnClear);
            this.gbCreateLoan.Controls.Add(this.btnCreateLoan);
            this.gbCreateLoan.Controls.Add(this.radLongTerm);
            this.gbCreateLoan.Controls.Add(this.radShortTerm);
            this.gbCreateLoan.Controls.Add(this.txtAmount);
            this.gbCreateLoan.Controls.Add(this.txtName);
            this.gbCreateLoan.Controls.Add(this.lblType);
            this.gbCreateLoan.Controls.Add(this.lblAmount);
            this.gbCreateLoan.Controls.Add(this.lblName);
            this.gbCreateLoan.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCreateLoan.Location = new System.Drawing.Point(29, 33);
            this.gbCreateLoan.Name = "gbCreateLoan";
            this.gbCreateLoan.Size = new System.Drawing.Size(848, 278);
            this.gbCreateLoan.TabIndex = 0;
            this.gbCreateLoan.TabStop = false;
            this.gbCreateLoan.Text = "Create Loan";
            // 
            // gbManageLoan
            // 
            this.gbManageLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbManageLoan.Controls.Add(this.btnExit);
            this.gbManageLoan.Controls.Add(this.btnMakePayment);
            this.gbManageLoan.Controls.Add(this.lblDueResults);
            this.gbManageLoan.Controls.Add(this.lblCurrentResults);
            this.gbManageLoan.Controls.Add(this.lblAmountResults);
            this.gbManageLoan.Controls.Add(this.lblLoanTypeResults);
            this.gbManageLoan.Controls.Add(this.lblNameResults);
            this.gbManageLoan.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbManageLoan.Location = new System.Drawing.Point(29, 349);
            this.gbManageLoan.Name = "gbManageLoan";
            this.gbManageLoan.Size = new System.Drawing.Size(848, 343);
            this.gbManageLoan.TabIndex = 1;
            this.gbManageLoan.TabStop = false;
            this.gbManageLoan.Text = "Manage Loan";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(49, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(139, 36);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblAmount.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(49, 126);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(139, 36);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount:";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblType.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(49, 204);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(139, 36);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(208, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(374, 38);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(208, 123);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(374, 38);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radShortTerm
            // 
            this.radShortTerm.AutoSize = true;
            this.radShortTerm.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radShortTerm.Location = new System.Drawing.Point(230, 204);
            this.radShortTerm.Name = "radShortTerm";
            this.radShortTerm.Size = new System.Drawing.Size(212, 35);
            this.radShortTerm.TabIndex = 4;
            this.radShortTerm.TabStop = true;
            this.radShortTerm.Text = "Short Term Loan";
            this.radShortTerm.UseVisualStyleBackColor = true;
            // 
            // radLongTerm
            // 
            this.radLongTerm.AutoSize = true;
            this.radLongTerm.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLongTerm.Location = new System.Drawing.Point(479, 205);
            this.radLongTerm.Name = "radLongTerm";
            this.radLongTerm.Size = new System.Drawing.Size(209, 35);
            this.radLongTerm.TabIndex = 5;
            this.radLongTerm.TabStop = true;
            this.radLongTerm.Text = "Long Term Loan";
            this.radLongTerm.UseVisualStyleBackColor = true;
            // 
            // btnCreateLoan
            // 
            this.btnCreateLoan.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateLoan.Location = new System.Drawing.Point(625, 48);
            this.btnCreateLoan.Name = "btnCreateLoan";
            this.btnCreateLoan.Size = new System.Drawing.Size(184, 38);
            this.btnCreateLoan.TabIndex = 2;
            this.btnCreateLoan.Text = "Create Loan";
            this.btnCreateLoan.UseVisualStyleBackColor = true;
            this.btnCreateLoan.Click += new System.EventHandler(this.btnCreateLoan_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(625, 126);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(184, 38);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblNameResults
            // 
            this.lblNameResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblNameResults.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameResults.Location = new System.Drawing.Point(49, 48);
            this.lblNameResults.Name = "lblNameResults";
            this.lblNameResults.Size = new System.Drawing.Size(597, 31);
            this.lblNameResults.TabIndex = 2;
            this.lblNameResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoanTypeResults
            // 
            this.lblLoanTypeResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblLoanTypeResults.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanTypeResults.Location = new System.Drawing.Point(49, 107);
            this.lblLoanTypeResults.Name = "lblLoanTypeResults";
            this.lblLoanTypeResults.Size = new System.Drawing.Size(269, 36);
            this.lblLoanTypeResults.TabIndex = 3;
            this.lblLoanTypeResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmountResults
            // 
            this.lblAmountResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAmountResults.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountResults.Location = new System.Drawing.Point(353, 107);
            this.lblAmountResults.Name = "lblAmountResults";
            this.lblAmountResults.Size = new System.Drawing.Size(293, 36);
            this.lblAmountResults.TabIndex = 4;
            this.lblAmountResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentResults
            // 
            this.lblCurrentResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCurrentResults.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentResults.Location = new System.Drawing.Point(49, 170);
            this.lblCurrentResults.Name = "lblCurrentResults";
            this.lblCurrentResults.Size = new System.Drawing.Size(760, 36);
            this.lblCurrentResults.TabIndex = 5;
            this.lblCurrentResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDueResults
            // 
            this.lblDueResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblDueResults.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueResults.Location = new System.Drawing.Point(49, 242);
            this.lblDueResults.Name = "lblDueResults";
            this.lblDueResults.Size = new System.Drawing.Size(760, 36);
            this.lblDueResults.TabIndex = 6;
            this.lblDueResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.BackColor = System.Drawing.Color.White;
            this.btnMakePayment.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakePayment.Location = new System.Drawing.Point(662, 41);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(180, 38);
            this.btnMakePayment.TabIndex = 0;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = false;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(662, 107);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 38);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBankLoan
            // 
            this.AcceptButton = this.btnCreateLoan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(920, 721);
            this.Controls.Add(this.gbManageLoan);
            this.Controls.Add(this.gbCreateLoan);
            this.Name = "frmBankLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Loan";
            this.gbCreateLoan.ResumeLayout(false);
            this.gbCreateLoan.PerformLayout();
            this.gbManageLoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreateLoan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreateLoan;
        private System.Windows.Forms.RadioButton radLongTerm;
        private System.Windows.Forms.RadioButton radShortTerm;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbManageLoan;
        private System.Windows.Forms.Label lblCurrentResults;
        private System.Windows.Forms.Label lblAmountResults;
        private System.Windows.Forms.Label lblLoanTypeResults;
        private System.Windows.Forms.Label lblNameResults;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Label lblDueResults;
    }
}

