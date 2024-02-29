namespace HOT9_11
{
    partial class frmCardStore
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
            this.lblOccasion = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.cbOccasion = new System.Windows.Forms.ComboBox();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.gbExtras = new System.Windows.Forms.GroupBox();
            this.rbCustomMessage = new System.Windows.Forms.RadioButton();
            this.rbStamp = new System.Windows.Forms.RadioButton();
            this.rbEnvelope = new System.Windows.Forms.RadioButton();
            this.txtCustomMessage = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.pbCardImage = new System.Windows.Forms.PictureBox();
            this.gbExtras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOccasion
            // 
            this.lblOccasion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblOccasion.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccasion.Location = new System.Drawing.Point(88, 35);
            this.lblOccasion.Name = "lblOccasion";
            this.lblOccasion.Size = new System.Drawing.Size(176, 36);
            this.lblOccasion.TabIndex = 3;
            this.lblOccasion.Text = "Occasion";
            this.lblOccasion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStyle
            // 
            this.lblStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblStyle.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyle.Location = new System.Drawing.Point(88, 140);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(176, 36);
            this.lblStyle.TabIndex = 4;
            this.lblStyle.Text = "Style";
            this.lblStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbOccasion
            // 
            this.cbOccasion.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOccasion.FormattingEnabled = true;
            this.cbOccasion.Location = new System.Drawing.Point(313, 35);
            this.cbOccasion.Name = "cbOccasion";
            this.cbOccasion.Size = new System.Drawing.Size(268, 39);
            this.cbOccasion.TabIndex = 0;
            this.cbOccasion.SelectedIndexChanged += new System.EventHandler(this.cbOccasion_SelectedIndexChanged);
            // 
            // cbStyle
            // 
            this.cbStyle.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Location = new System.Drawing.Point(313, 140);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(268, 39);
            this.cbStyle.TabIndex = 1;
            this.cbStyle.SelectedIndexChanged += new System.EventHandler(this.cbStyle_SelectedIndexChanged);
            // 
            // gbExtras
            // 
            this.gbExtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbExtras.Controls.Add(this.rbCustomMessage);
            this.gbExtras.Controls.Add(this.rbStamp);
            this.gbExtras.Controls.Add(this.rbEnvelope);
            this.gbExtras.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbExtras.Location = new System.Drawing.Point(91, 227);
            this.gbExtras.Name = "gbExtras";
            this.gbExtras.Size = new System.Drawing.Size(220, 208);
            this.gbExtras.TabIndex = 5;
            this.gbExtras.TabStop = false;
            this.gbExtras.Text = "Extras";
            // 
            // rbCustomMessage
            // 
            this.rbCustomMessage.AutoSize = true;
            this.rbCustomMessage.Location = new System.Drawing.Point(26, 156);
            this.rbCustomMessage.Name = "rbCustomMessage";
            this.rbCustomMessage.Size = new System.Drawing.Size(184, 24);
            this.rbCustomMessage.TabIndex = 2;
            this.rbCustomMessage.TabStop = true;
            this.rbCustomMessage.Text = "Custom Messsage ($0.30)";
            this.rbCustomMessage.UseVisualStyleBackColor = true;
            this.rbCustomMessage.CheckedChanged += new System.EventHandler(this.rbCustomMessage_CheckedChanged);
            // 
            // rbStamp
            // 
            this.rbStamp.AutoSize = true;
            this.rbStamp.Location = new System.Drawing.Point(26, 101);
            this.rbStamp.Name = "rbStamp";
            this.rbStamp.Size = new System.Drawing.Size(111, 24);
            this.rbStamp.TabIndex = 1;
            this.rbStamp.TabStop = true;
            this.rbStamp.Text = "Stamp ($0.50)";
            this.rbStamp.UseVisualStyleBackColor = true;
            this.rbStamp.CheckedChanged += new System.EventHandler(this.rbStamp_CheckedChanged);
            // 
            // rbEnvelope
            // 
            this.rbEnvelope.AutoSize = true;
            this.rbEnvelope.Location = new System.Drawing.Point(26, 40);
            this.rbEnvelope.Name = "rbEnvelope";
            this.rbEnvelope.Size = new System.Drawing.Size(129, 24);
            this.rbEnvelope.TabIndex = 0;
            this.rbEnvelope.TabStop = true;
            this.rbEnvelope.Text = "Envelope ($0.25)";
            this.rbEnvelope.UseVisualStyleBackColor = true;
            this.rbEnvelope.CheckedChanged += new System.EventHandler(this.rbEnvelope_CheckedChanged);
            // 
            // txtCustomMessage
            // 
            this.txtCustomMessage.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomMessage.Location = new System.Drawing.Point(91, 466);
            this.txtCustomMessage.Multiline = true;
            this.txtCustomMessage.Name = "txtCustomMessage";
            this.txtCustomMessage.Size = new System.Drawing.Size(490, 243);
            this.txtCustomMessage.TabIndex = 2;
            this.txtCustomMessage.TextChanged += new System.EventHandler(this.txtCustomMessage_TextChanged);
            // 
            // lblCost
            // 
            this.lblCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblCost.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(88, 744);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(176, 36);
            this.lblCost.TabIndex = 6;
            this.lblCost.Text = "Cost:";
            // 
            // pbCardImage
            // 
            this.pbCardImage.Location = new System.Drawing.Point(627, 35);
            this.pbCardImage.Name = "pbCardImage";
            this.pbCardImage.Size = new System.Drawing.Size(610, 745);
            this.pbCardImage.TabIndex = 7;
            this.pbCardImage.TabStop = false;
            // 
            // frmCardStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1259, 807);
            this.Controls.Add(this.pbCardImage);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtCustomMessage);
            this.Controls.Add(this.gbExtras);
            this.Controls.Add(this.cbStyle);
            this.Controls.Add(this.cbOccasion);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.lblOccasion);
            this.Name = "frmCardStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Designer";
            this.Load += new System.EventHandler(this.frmCardStore_Load);
            this.gbExtras.ResumeLayout(false);
            this.gbExtras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOccasion;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.ComboBox cbOccasion;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.GroupBox gbExtras;
        private System.Windows.Forms.TextBox txtCustomMessage;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.PictureBox pbCardImage;
        private System.Windows.Forms.RadioButton rbCustomMessage;
        private System.Windows.Forms.RadioButton rbStamp;
        private System.Windows.Forms.RadioButton rbEnvelope;
    }
}

