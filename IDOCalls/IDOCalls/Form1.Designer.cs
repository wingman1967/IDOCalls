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
            this.SuspendLayout();
            // 
            // btnOpenSession
            // 
            this.btnOpenSession.Location = new System.Drawing.Point(12, 30);
            this.btnOpenSession.Name = "btnOpenSession";
            this.btnOpenSession.Size = new System.Drawing.Size(110, 23);
            this.btnOpenSession.TabIndex = 0;
            this.btnOpenSession.Text = "Open Session";
            this.btnOpenSession.UseVisualStyleBackColor = true;
            this.btnOpenSession.Click += new System.EventHandler(this.btnOpenSession_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(25, 126);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(193, 23);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "SessionStatus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 261);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnOpenSession);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenSession;
        private System.Windows.Forms.Label lblStatus;
    }
}

