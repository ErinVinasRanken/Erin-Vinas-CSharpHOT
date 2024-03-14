namespace Homework12_01
{
    partial class frmPassworkCrack
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMD5Hash = new Label();
            lblResults = new Label();
            txtMD5Hash = new TextBox();
            btnCrack = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblMD5Hash
            // 
            lblMD5Hash.BackColor = Color.FromArgb(255, 128, 128);
            lblMD5Hash.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblMD5Hash.Location = new Point(36, 37);
            lblMD5Hash.Name = "lblMD5Hash";
            lblMD5Hash.Size = new Size(184, 31);
            lblMD5Hash.TabIndex = 3;
            lblMD5Hash.Text = "MD5 Hash";
            lblMD5Hash.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResults
            // 
            lblResults.BackColor = Color.FromArgb(255, 128, 128);
            lblResults.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblResults.Location = new Point(36, 176);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(639, 88);
            lblResults.TabIndex = 2;
            // 
            // txtMD5Hash
            // 
            txtMD5Hash.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtMD5Hash.Location = new Point(36, 92);
            txtMD5Hash.Name = "txtMD5Hash";
            txtMD5Hash.Size = new Size(639, 38);
            txtMD5Hash.TabIndex = 0;
            // 
            // btnCrack
            // 
            btnCrack.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnCrack.Location = new Point(701, 87);
            btnCrack.Name = "btnCrack";
            btnCrack.Size = new Size(114, 46);
            btnCrack.TabIndex = 1;
            btnCrack.Text = "&Crack";
            btnCrack.UseVisualStyleBackColor = true;
            btnCrack.Click += btnCrack_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(701, 218);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 46);
            btnClear.TabIndex = 4;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmPassworkCrack
            // 
            AcceptButton = btnCrack;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            CancelButton = btnClear;
            ClientSize = new Size(827, 293);
            Controls.Add(btnClear);
            Controls.Add(btnCrack);
            Controls.Add(txtMD5Hash);
            Controls.Add(lblResults);
            Controls.Add(lblMD5Hash);
            Name = "frmPassworkCrack";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Cracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMD5Hash;
        private Label lblResults;
        private TextBox txtMD5Hash;
        private Button btnCrack;
        private Button btnClear;
    }
}
