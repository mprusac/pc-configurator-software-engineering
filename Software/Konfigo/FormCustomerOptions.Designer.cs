namespace Konfigo
{
    partial class FormCustomerOptions
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
            this.components = new System.ComponentModel.Container();
            this.btnCreateConfiguration = new System.Windows.Forms.Button();
            this.btnPredefinedConfigs = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnBrowseAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateConfiguration
            // 
            this.btnCreateConfiguration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreateConfiguration.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateConfiguration.Location = new System.Drawing.Point(57, 98);
            this.btnCreateConfiguration.Name = "btnCreateConfiguration";
            this.btnCreateConfiguration.Size = new System.Drawing.Size(120, 85);
            this.btnCreateConfiguration.TabIndex = 0;
            this.btnCreateConfiguration.Text = "Kreiraj vlastitu konfiguraciju";
            this.btnCreateConfiguration.UseVisualStyleBackColor = false;
            this.btnCreateConfiguration.Click += new System.EventHandler(this.btnCreateConfiguration_Click);
            // 
            // btnPredefinedConfigs
            // 
            this.btnPredefinedConfigs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPredefinedConfigs.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPredefinedConfigs.Location = new System.Drawing.Point(209, 98);
            this.btnPredefinedConfigs.Name = "btnPredefinedConfigs";
            this.btnPredefinedConfigs.Size = new System.Drawing.Size(120, 85);
            this.btnPredefinedConfigs.TabIndex = 1;
            this.btnPredefinedConfigs.Text = "Odaberi gotovu konfiguraciju";
            this.btnPredefinedConfigs.UseVisualStyleBackColor = false;
            this.btnPredefinedConfigs.Click += new System.EventHandler(this.btnPredefinedConfigs_Click);
            // 
            // btnBrowseAll
            // 
            this.btnBrowseAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBrowseAll.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrowseAll.Location = new System.Drawing.Point(360, 98);
            this.btnBrowseAll.Name = "btnBrowseAll";
            this.btnBrowseAll.Size = new System.Drawing.Size(120, 85);
            this.btnBrowseAll.TabIndex = 2;
            this.btnBrowseAll.Text = "Pregledaj sve komponente";
            this.btnBrowseAll.UseVisualStyleBackColor = false;
            this.btnBrowseAll.Click += new System.EventHandler(this.btnBrowseAll_Click);
            // 
            // FormCustomerOptions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(543, 303);
            this.Controls.Add(this.btnBrowseAll);
            this.Controls.Add(this.btnPredefinedConfigs);
            this.Controls.Add(this.btnCreateConfiguration);
            this.Name = "FormCustomerOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opcije kupca";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateConfiguration;
        private System.Windows.Forms.Button btnPredefinedConfigs;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnBrowseAll;
    }
}