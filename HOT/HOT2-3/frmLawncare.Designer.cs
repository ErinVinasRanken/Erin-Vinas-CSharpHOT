namespace HOT2_3
{
    partial class frmLawncare
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblWeeklyFee = new System.Windows.Forms.Label();
            this.lblSeasonLength = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblLength.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(184, 37);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(160, 34);
            this.lblLength.TabIndex = 6;
            this.lblLength.Text = "Length (ft):";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWidth
            // 
            this.lblWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblWidth.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(443, 37);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(160, 34);
            this.lblWidth.TabIndex = 7;
            this.lblWidth.Text = "Width (ft):";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(190, 110);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(154, 38);
            this.txtLength.TabIndex = 0;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(449, 110);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(154, 38);
            this.txtWidth.TabIndex = 1;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(87, 170);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(154, 45);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(320, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 45);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(548, 170);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 45);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblResult.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 261);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(776, 44);
            this.lblResult.TabIndex = 5;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArea
            // 
            this.lblArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblArea.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(12, 250);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(776, 44);
            this.lblArea.TabIndex = 8;
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeeklyFee
            // 
            this.lblWeeklyFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblWeeklyFee.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyFee.Location = new System.Drawing.Point(12, 294);
            this.lblWeeklyFee.Name = "lblWeeklyFee";
            this.lblWeeklyFee.Size = new System.Drawing.Size(776, 44);
            this.lblWeeklyFee.TabIndex = 9;
            this.lblWeeklyFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeasonLength
            // 
            this.lblSeasonLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSeasonLength.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeasonLength.Location = new System.Drawing.Point(12, 338);
            this.lblSeasonLength.Name = "lblSeasonLength";
            this.lblSeasonLength.Size = new System.Drawing.Size(776, 44);
            this.lblSeasonLength.TabIndex = 10;
            this.lblSeasonLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotalCost.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(12, 382);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(776, 44);
            this.lblTotalCost.TabIndex = 11;
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLawncare
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblSeasonLength);
            this.Controls.Add(this.lblWeeklyFee);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "frmLawncare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Greg\'s Lawncare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblWeeklyFee;
        private System.Windows.Forms.Label lblSeasonLength;
        private System.Windows.Forms.Label lblTotalCost;
    }
}

