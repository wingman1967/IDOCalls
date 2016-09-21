namespace IDOCalls
{
    partial class Form1
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
            this.btnOpenSession = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.txtLineNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtSessionToken = new System.Windows.Forms.TextBox();
            this.btnGetRecord = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMG = new System.Windows.Forms.TextBox();
            this.lsvIDO = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.cboIDOs = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenSession
            // 
            this.btnOpenSession.Location = new System.Drawing.Point(340, 9);
            this.btnOpenSession.Name = "btnOpenSession";
            this.btnOpenSession.Size = new System.Drawing.Size(161, 13);
            this.btnOpenSession.TabIndex = 0;
            this.btnOpenSession.Text = "Open Session";
            this.btnOpenSession.UseVisualStyleBackColor = true;
            this.btnOpenSession.Visible = false;
            this.btnOpenSession.Click += new System.EventHandler(this.btnOpenSession_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(507, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(139, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "SessionStatus";
            this.lblStatus.Visible = false;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(25, 84);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(155, 20);
            this.txtOrderNumber.TabIndex = 3;
            this.txtOrderNumber.Visible = false;
            // 
            // txtLineNumber
            // 
            this.txtLineNumber.Location = new System.Drawing.Point(215, 84);
            this.txtLineNumber.Name = "txtLineNumber";
            this.txtLineNumber.Size = new System.Drawing.Size(48, 20);
            this.txtLineNumber.TabIndex = 4;
            this.txtLineNumber.Visible = false;
            this.txtLineNumber.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Order#";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Line#";
            this.label2.Visible = false;
            // 
            // lblItem
            // 
            this.lblItem.Location = new System.Drawing.Point(26, 120);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(117, 23);
            this.lblItem.TabIndex = 7;
            this.lblItem.Text = "[item]";
            this.lblItem.Visible = false;
            // 
            // txtSessionToken
            // 
            this.txtSessionToken.Location = new System.Drawing.Point(329, 84);
            this.txtSessionToken.Multiline = true;
            this.txtSessionToken.Name = "txtSessionToken";
            this.txtSessionToken.Size = new System.Drawing.Size(270, 86);
            this.txtSessionToken.TabIndex = 8;
            // 
            // btnGetRecord
            // 
            this.btnGetRecord.Location = new System.Drawing.Point(19, 33);
            this.btnGetRecord.Name = "btnGetRecord";
            this.btnGetRecord.Size = new System.Drawing.Size(161, 23);
            this.btnGetRecord.TabIndex = 9;
            this.btnGetRecord.Text = "Retrieve";
            this.btnGetRecord.UseVisualStyleBackColor = true;
            this.btnGetRecord.Click += new System.EventHandler(this.btnGetRecord_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(194, 120);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(129, 23);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "[description]";
            this.lblDescription.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Item#";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "SessionToken";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboIDOs);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lsvIDO);
            this.groupBox1.Controls.Add(this.txtMG);
            this.groupBox1.Controls.Add(this.txtSessionToken);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtOrderNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLineNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGetRecord);
            this.groupBox1.Controls.Add(this.lblItem);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 628);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IDO Test Parameters";
            // 
            // txtMG
            // 
            this.txtMG.Location = new System.Drawing.Point(485, 23);
            this.txtMG.Multiline = true;
            this.txtMG.Name = "txtMG";
            this.txtMG.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMG.Size = new System.Drawing.Size(114, 33);
            this.txtMG.TabIndex = 14;
            this.txtMG.Visible = false;
            // 
            // lsvIDO
            // 
            this.lsvIDO.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lsvIDO.ForeColor = System.Drawing.SystemColors.Window;
            this.lsvIDO.FullRowSelect = true;
            this.lsvIDO.GridLines = true;
            this.lsvIDO.Location = new System.Drawing.Point(6, 218);
            this.lsvIDO.Name = "lsvIDO";
            this.lsvIDO.Size = new System.Drawing.Size(874, 404);
            this.lsvIDO.TabIndex = 15;
            this.lsvIDO.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "IDO Properties";
            this.label6.Visible = false;
            // 
            // cboIDOs
            // 
            this.cboIDOs.FormattingEnabled = true;
            this.cboIDOs.Location = new System.Drawing.Point(9, 166);
            this.cboIDOs.Name = "cboIDOs";
            this.cboIDOs.Size = new System.Drawing.Size(213, 21);
            this.cboIDOs.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "IDOs";
            this.label7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnOpenSession);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDO via WebService";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenSession;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.TextBox txtLineNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtSessionToken;
        private System.Windows.Forms.Button btnGetRecord;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMG;
        private System.Windows.Forms.ListView lsvIDO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboIDOs;
    }
}

