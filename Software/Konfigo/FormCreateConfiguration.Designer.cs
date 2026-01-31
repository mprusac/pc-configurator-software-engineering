namespace Konfigo
{
    partial class FormCreateConfiguration
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flpTypes;
        private System.Windows.Forms.DataGridView dgvComponents;
        private System.Windows.Forms.DataGridView dgvSelected;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSend;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.flpTypes = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvComponents = new System.Windows.Forms.DataGridView();
            this.dgvSelected = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // flpTypes
            // 
            this.flpTypes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.flpTypes.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flpTypes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flpTypes.Location = new System.Drawing.Point(12, 12);
            this.flpTypes.Name = "flpTypes";
            this.flpTypes.Size = new System.Drawing.Size(173, 400);
            this.flpTypes.TabIndex = 0;
            // 
            // dgvComponents
            // 
            this.dgvComponents.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComponents.Location = new System.Drawing.Point(210, 12);
            this.dgvComponents.Name = "dgvComponents";
            this.dgvComponents.RowHeadersWidth = 51;
            this.dgvComponents.Size = new System.Drawing.Size(679, 150);
            this.dgvComponents.TabIndex = 1;
            // 
            // dgvSelected
            // 
            this.dgvSelected.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelected.Location = new System.Drawing.Point(210, 178);
            this.dgvSelected.Name = "dgvSelected";
            this.dgvSelected.RowHeadersWidth = 51;
            this.dgvSelected.Size = new System.Drawing.Size(679, 150);
            this.dgvSelected.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotal.Location = new System.Drawing.Point(701, 337);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(109, 17);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Ukupno: 0.00 €";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(586, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 51);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Spremi konfiguraciju";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSend.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSend.Location = new System.Drawing.Point(749, 361);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(140, 51);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Pošalji zaposleniku";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // FormCreateConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(907, 423);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvSelected);
            this.Controls.Add(this.dgvComponents);
            this.Controls.Add(this.flpTypes);
            this.Name = "FormCreateConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiranje konfiguracije";
            this.Load += new System.EventHandler(this.FormCreateConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
