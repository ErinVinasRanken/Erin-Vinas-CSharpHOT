namespace HOT8_2
{
    partial class frmNameList
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
            this.lblEnterAName = new System.Windows.Forms.Label();
            this.txtEnterAName = new System.Windows.Forms.TextBox();
            this.lvNames = new System.Windows.Forms.ListView();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnUpdateName = new System.Windows.Forms.Button();
            this.btnDeleteName = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNameList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterAName
            // 
            this.lblEnterAName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblEnterAName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterAName.Location = new System.Drawing.Point(134, 44);
            this.lblEnterAName.Name = "lblEnterAName";
            this.lblEnterAName.Size = new System.Drawing.Size(208, 35);
            this.lblEnterAName.TabIndex = 7;
            this.lblEnterAName.Text = "Enter A Name";
            // 
            // txtEnterAName
            // 
            this.txtEnterAName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterAName.Location = new System.Drawing.Point(137, 114);
            this.txtEnterAName.Name = "txtEnterAName";
            this.txtEnterAName.Size = new System.Drawing.Size(205, 38);
            this.txtEnterAName.TabIndex = 0;
            this.txtEnterAName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lvNames
            // 
            this.lvNames.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvNames.HideSelection = false;
            this.lvNames.Location = new System.Drawing.Point(434, 112);
            this.lvNames.Name = "lvNames";
            this.lvNames.Size = new System.Drawing.Size(315, 191);
            this.lvNames.TabIndex = 6;
            this.lvNames.UseCompatibleStateImageBehavior = false;
            this.lvNames.SelectedIndexChanged += new System.EventHandler(this.lvNames_SelectedIndexChanged);
            // 
            // btnAddName
            // 
            this.btnAddName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddName.Location = new System.Drawing.Point(137, 185);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(205, 37);
            this.btnAddName.TabIndex = 1;
            this.btnAddName.Text = "Add A Name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnUpdateName
            // 
            this.btnUpdateName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateName.Location = new System.Drawing.Point(140, 256);
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(205, 37);
            this.btnUpdateName.TabIndex = 2;
            this.btnUpdateName.Text = "Update A Name";
            this.btnUpdateName.UseVisualStyleBackColor = true;
            this.btnUpdateName.Click += new System.EventHandler(this.btnUpdateName_Click);
            // 
            // btnDeleteName
            // 
            this.btnDeleteName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteName.Location = new System.Drawing.Point(140, 324);
            this.btnDeleteName.Name = "btnDeleteName";
            this.btnDeleteName.Size = new System.Drawing.Size(205, 37);
            this.btnDeleteName.TabIndex = 3;
            this.btnDeleteName.Text = "Delete A Name";
            this.btnDeleteName.UseVisualStyleBackColor = true;
            this.btnDeleteName.Click += new System.EventHandler(this.btnDeleteName_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(495, 324);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(205, 37);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(495, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(205, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNameList
            // 
            this.lblNameList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblNameList.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameList.Location = new System.Drawing.Point(516, 44);
            this.lblNameList.Name = "lblNameList";
            this.lblNameList.Size = new System.Drawing.Size(208, 35);
            this.lblNameList.TabIndex = 8;
            this.lblNameList.Text = "Name List";
            // 
            // frmNameList
            // 
            this.AcceptButton = this.btnAddName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNameList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDeleteName);
            this.Controls.Add(this.btnUpdateName);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.lvNames);
            this.Controls.Add(this.txtEnterAName);
            this.Controls.Add(this.lblEnterAName);
            this.Name = "frmNameList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First Name List";
            this.Load += new System.EventHandler(this.frmNameList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterAName;
        private System.Windows.Forms.TextBox txtEnterAName;
        private System.Windows.Forms.ListView lvNames;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnUpdateName;
        private System.Windows.Forms.Button btnDeleteName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNameList;
    }
}

