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
<<<<<<< HEAD
            this.txtSessionToken = new System.Windows.Forms.TextBox();
            this.btnConnectToSyteline = new System.Windows.Forms.Button();
=======
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
>>>>>>> origin/master
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
<<<<<<< HEAD
            // txtSessionToken
            // 
            this.txtSessionToken.Location = new System.Drawing.Point(466, 63);
            this.txtSessionToken.Margin = new System.Windows.Forms.Padding(6);
            this.txtSessionToken.Multiline = true;
            this.txtSessionToken.Name = "txtSessionToken";
            this.txtSessionToken.Size = new System.Drawing.Size(801, 162);
            this.txtSessionToken.TabIndex = 8;
            // 
            // btnConnectToSyteline
            // 
            this.btnConnectToSyteline.Location = new System.Drawing.Point(38, 63);
            this.btnConnectToSyteline.Margin = new System.Windows.Forms.Padding(6);
            this.btnConnectToSyteline.Name = "btnConnectToSyteline";
            this.btnConnectToSyteline.Size = new System.Drawing.Size(322, 44);
            this.btnConnectToSyteline.TabIndex = 9;
            this.btnConnectToSyteline.Text = "Connect to Syteline";
            this.btnConnectToSyteline.UseVisualStyleBackColor = true;
            this.btnConnectToSyteline.Click += new System.EventHandler(this.btnConnectToSyteline_Click);
=======
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
            // 
            // txtLineNumber
            // 
            this.txtLineNumber.Location = new System.Drawing.Point(215, 84);
            this.txtLineNumber.Name = "txtLineNumber";
            this.txtLineNumber.Size = new System.Drawing.Size(48, 20);
            this.txtLineNumber.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Order#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Line#";
            // 
            // lblItem
            // 
            this.lblItem.Location = new System.Drawing.Point(27, 147);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(117, 23);
            this.lblItem.TabIndex = 7;
            this.lblItem.Text = "[item]";
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
            this.btnGetRecord.Text = "Retrieve Record";
            this.btnGetRecord.UseVisualStyleBackColor = true;
            this.btnGetRecord.Click += new System.EventHandler(this.btnGetRecord_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(195, 147);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(129, 23);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "[description]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Item#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description";
>>>>>>> origin/master
            // 
            // label5
            // 
            this.label5.AutoSize = true;
<<<<<<< HEAD
            this.label5.Location = new System.Drawing.Point(464, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
=======
            this.label5.Location = new System.Drawing.Point(328, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
>>>>>>> origin/master
            this.label5.TabIndex = 13;
            this.label5.Text = "SessionToken";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSessionToken);
            this.groupBox1.Controls.Add(this.label5);
<<<<<<< HEAD
            this.groupBox1.Controls.Add(this.btnConnectToSyteline);
            this.groupBox1.Location = new System.Drawing.Point(24, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1292, 741);
=======
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
            this.groupBox1.Size = new System.Drawing.Size(646, 236);
>>>>>>> origin/master
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IDO Test Parameters";
            // 
            // Form1
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 976);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnOpenSession);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
>>>>>>> origin/master
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDO via WebService";
<<<<<<< HEAD
=======
            this.Load += new System.EventHandler(this.Form1_Load);
>>>>>>> origin/master
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
<<<<<<< HEAD
        private System.Windows.Forms.TextBox txtSessionToken;
        private System.Windows.Forms.Button btnConnectToSyteline;
=======

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
>>>>>>> origin/master
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

