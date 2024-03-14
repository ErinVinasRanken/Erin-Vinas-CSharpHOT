namespace HOT12_2
{
    partial class frmNetworkScanner
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
            lblIPAddress = new Label();
            txtIPAddress = new TextBox();
            btnScan = new Button();
            lblComputerName = new Label();
            lblServices = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblIPAddress
            // 
            lblIPAddress.BackColor = Color.FromArgb(255, 224, 192);
            lblIPAddress.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblIPAddress.Location = new Point(47, 39);
            lblIPAddress.Name = "lblIPAddress";
            lblIPAddress.Size = new Size(200, 36);
            lblIPAddress.TabIndex = 3;
            lblIPAddress.Text = "IP Address";
            lblIPAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIPAddress
            // 
            txtIPAddress.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            txtIPAddress.Location = new Point(47, 92);
            txtIPAddress.Name = "txtIPAddress";
            txtIPAddress.Size = new Size(541, 38);
            txtIPAddress.TabIndex = 0;
            // 
            // btnScan
            // 
            btnScan.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnScan.Location = new Point(615, 83);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(117, 44);
            btnScan.TabIndex = 1;
            btnScan.Text = "&Scan";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            // 
            // lblComputerName
            // 
            lblComputerName.BackColor = Color.FromArgb(255, 224, 192);
            lblComputerName.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            lblComputerName.Location = new Point(47, 156);
            lblComputerName.Name = "lblComputerName";
            lblComputerName.Size = new Size(471, 94);
            lblComputerName.TabIndex = 4;
            // 
            // lblServices
            // 
            lblServices.BackColor = Color.FromArgb(255, 224, 192);
            lblServices.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblServices.Location = new Point(47, 273);
            lblServices.Name = "lblServices";
            lblServices.Size = new Size(471, 365);
            lblServices.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(615, 206);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 44);
            btnClear.TabIndex = 2;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmNetworkScanner
            // 
            AcceptButton = btnScan;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            CancelButton = btnClear;
            ClientSize = new Size(744, 664);
            Controls.Add(btnClear);
            Controls.Add(lblServices);
            Controls.Add(lblComputerName);
            Controls.Add(btnScan);
            Controls.Add(txtIPAddress);
            Controls.Add(lblIPAddress);
            Name = "frmNetworkScanner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Network Scanner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIPAddress;
        private TextBox txtIPAddress;
        private Button btnScan;
        private Label lblComputerName;
        private Label lblServices;
        private Button btnClear;
    }
}
