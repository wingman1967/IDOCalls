namespace IDOCalls
{
    partial class savedata
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
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExpiration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrintOnNamePlate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSavePatent = new System.Windows.Forms.Button();
            this.txtSessionToken = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(12, 67);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(68, 20);
            this.txtComments.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comments";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(108, 67);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(229, 20);
            this.txtCountry.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Country";
            // 
            // txtExpiration
            // 
            this.txtExpiration.Location = new System.Drawing.Point(357, 67);
            this.txtExpiration.Name = "txtExpiration";
            this.txtExpiration.Size = new System.Drawing.Size(119, 20);
            this.txtExpiration.TabIndex = 4;
            this.txtExpiration.Text = "2016-09-27 00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expiration";
            // 
            // txtPatent
            // 
            this.txtPatent.Location = new System.Drawing.Point(525, 67);
            this.txtPatent.Name = "txtPatent";
            this.txtPatent.Size = new System.Drawing.Size(70, 20);
            this.txtPatent.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Patent";
            // 
            // txtPrintOnNamePlate
            // 
            this.txtPrintOnNamePlate.Location = new System.Drawing.Point(628, 67);
            this.txtPrintOnNamePlate.Name = "txtPrintOnNamePlate";
            this.txtPrintOnNamePlate.Size = new System.Drawing.Size(92, 20);
            this.txtPrintOnNamePlate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Print on nameplate";
            // 
            // btnSavePatent
            // 
            this.btnSavePatent.Location = new System.Drawing.Point(15, 184);
            this.btnSavePatent.Name = "btnSavePatent";
            this.btnSavePatent.Size = new System.Drawing.Size(127, 23);
            this.btnSavePatent.TabIndex = 14;
            this.btnSavePatent.Text = "Save Patent";
            this.btnSavePatent.UseVisualStyleBackColor = true;
            this.btnSavePatent.Click += new System.EventHandler(this.btnSavePatent_Click);
            // 
            // txtSessionToken
            // 
            this.txtSessionToken.Location = new System.Drawing.Point(284, 126);
            this.txtSessionToken.Multiline = true;
            this.txtSessionToken.Name = "txtSessionToken";
            this.txtSessionToken.Size = new System.Drawing.Size(484, 81);
            this.txtSessionToken.TabIndex = 15;
            // 
            // savedata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 238);
            this.Controls.Add(this.txtSessionToken);
            this.Controls.Add(this.btnSavePatent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrintOnNamePlate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPatent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExpiration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComments);
            this.Name = "savedata";
            this.Text = "SaveDataSet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExpiration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrintOnNamePlate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSavePatent;
        public System.Windows.Forms.TextBox txtSessionToken;
    }
}