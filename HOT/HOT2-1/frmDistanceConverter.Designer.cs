namespace HOT2_1
{
    partial class frmDistanceConverter
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
            this.lblDistanceInInches = new System.Windows.Forms.Label();
            this.txtDistanceInInches = new System.Windows.Forms.TextBox();
            this.btnConverToYrads = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDistanceInInches
            // 
            this.lblDistanceInInches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDistanceInInches.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanceInInches.Location = new System.Drawing.Point(296, 63);
            this.lblDistanceInInches.Name = "lblDistanceInInches";
            this.lblDistanceInInches.Size = new System.Drawing.Size(215, 40);
            this.lblDistanceInInches.TabIndex = 4;
            this.lblDistanceInInches.Text = "Distance In Inches:";
            this.lblDistanceInInches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDistanceInInches
            // 
            this.txtDistanceInInches.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistanceInInches.Location = new System.Drawing.Point(295, 134);
            this.txtDistanceInInches.Name = "txtDistanceInInches";
            this.txtDistanceInInches.Size = new System.Drawing.Size(216, 38);
            this.txtDistanceInInches.TabIndex = 0;
            // 
            // btnConverToYrads
            // 
            this.btnConverToYrads.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverToYrads.Location = new System.Drawing.Point(66, 233);
            this.btnConverToYrads.Name = "btnConverToYrads";
            this.btnConverToYrads.Size = new System.Drawing.Size(183, 82);
            this.btnConverToYrads.TabIndex = 1;
            this.btnConverToYrads.Text = "&Convert To Yards";
            this.btnConverToYrads.UseVisualStyleBackColor = true;
            this.btnConverToYrads.Click += new System.EventHandler(this.btnConverToYrads_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(312, 233);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 82);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(557, 233);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 82);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblResult.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(112, 350);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(588, 40);
            this.lblResult.TabIndex = 5;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDistanceConverter
            // 
            this.AcceptButton = this.btnConverToYrads;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConverToYrads);
            this.Controls.Add(this.txtDistanceInInches);
            this.Controls.Add(this.lblDistanceInInches);
            this.Name = "frmDistanceConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distance Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDistanceInInches;
        private System.Windows.Forms.TextBox txtDistanceInInches;
        private System.Windows.Forms.Button btnConverToYrads;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
    }
}

