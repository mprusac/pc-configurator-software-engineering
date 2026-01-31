namespace Konfigo
{
    partial class FrmStart
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStart));
            this.btnEmployeeLogin = new System.Windows.Forms.Button();
            this.btnCustomerEnter = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmployeeLogin
            // 
            this.btnEmployeeLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmployeeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeLogin.Location = new System.Drawing.Point(118, 153);
            this.btnEmployeeLogin.Name = "btnEmployeeLogin";
            this.btnEmployeeLogin.Size = new System.Drawing.Size(100, 30);
            this.btnEmployeeLogin.TabIndex = 0;
            this.btnEmployeeLogin.Text = "Zaposlenik";
            this.btnEmployeeLogin.UseVisualStyleBackColor = false;
            this.btnEmployeeLogin.Click += new System.EventHandler(this.btnEmployeeLogin_Click);
            // 
            // btnCustomerEnter
            // 
            this.btnCustomerEnter.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCustomerEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerEnter.Location = new System.Drawing.Point(118, 204);
            this.btnCustomerEnter.Name = "btnCustomerEnter";
            this.btnCustomerEnter.Size = new System.Drawing.Size(100, 30);
            this.btnCustomerEnter.TabIndex = 1;
            this.btnCustomerEnter.Text = "Kupac";
            this.btnCustomerEnter.UseVisualStyleBackColor = false;
            this.btnCustomerEnter.Click += new System.EventHandler(this.btnCustomerEnter_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(114, 105);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Prijava kao:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmStart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(332, 303);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCustomerEnter);
            this.Controls.Add(this.btnEmployeeLogin);
            this.Name = "FrmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odabir uloge";
            this.Load += new System.EventHandler(this.FrmStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeLogin;
        private System.Windows.Forms.Button btnCustomerEnter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
