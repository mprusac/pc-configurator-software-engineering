namespace Konfigo
{
    partial class FormSavedConfigurations
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvConfigurations;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvConfigurations = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfigurations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConfigurations
            // 
            this.dgvConfigurations.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvConfigurations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfigurations.Location = new System.Drawing.Point(119, 17);
            this.dgvConfigurations.Name = "dgvConfigurations";
            this.dgvConfigurations.RowHeadersWidth = 51;
            this.dgvConfigurations.Size = new System.Drawing.Size(298, 257);
            this.dgvConfigurations.TabIndex = 0;
            this.dgvConfigurations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConfigurations_CellDoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(440, 244);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormSavedConfigurations
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(632, 303);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvConfigurations);
            this.Name = "FormSavedConfigurations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gotove konfiguracije";
            this.Load += new System.EventHandler(this.FormSavedConfigurations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfigurations)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
