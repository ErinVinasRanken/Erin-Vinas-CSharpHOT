namespace HOT2_2
{
    partial class frmLetterGrade
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
            this.lblGPA = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.btnLetterGrade = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGPA
            // 
            this.lblGPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblGPA.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPA.Location = new System.Drawing.Point(310, 61);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(138, 39);
            this.lblGPA.TabIndex = 4;
            this.lblGPA.Text = "GPA:";
            this.lblGPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGPA
            // 
            this.txtGPA.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPA.Location = new System.Drawing.Point(292, 134);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(174, 38);
            this.txtGPA.TabIndex = 0;
            this.txtGPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLetterGrade
            // 
            this.btnLetterGrade.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetterGrade.Location = new System.Drawing.Point(92, 237);
            this.btnLetterGrade.Name = "btnLetterGrade";
            this.btnLetterGrade.Size = new System.Drawing.Size(139, 72);
            this.btnLetterGrade.TabIndex = 1;
            this.btnLetterGrade.Text = "L&etter Grade";
            this.btnLetterGrade.UseVisualStyleBackColor = true;
            this.btnLetterGrade.Click += new System.EventHandler(this.btnLetterGrade_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(309, 237);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 72);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(522, 237);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 72);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblResult.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(168, 363);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(431, 39);
            this.lblResult.TabIndex = 5;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLetterGrade
            // 
            this.AcceptButton = this.btnLetterGrade;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLetterGrade);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.lblGPA);
            this.Name = "frmLetterGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letter Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.Button btnLetterGrade;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
    }
}

