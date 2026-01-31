using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Konfigo
{
    public partial class FormCustomerOptions : Form
    {
        public FormCustomerOptions()
        {
            InitializeComponent();
        }

        private void btnCreateConfiguration_Click(object sender, EventArgs e)
        {
            var form = new FormCreateConfiguration();
            form.ShowDialog();
        }

        private void btnPredefinedConfigs_Click(object sender, EventArgs e)
        {
            var form = new FormSavedConfigurations();
            form.ShowDialog();
        }

        private void btnBrowseAll_Click(object sender, EventArgs e)
        {
            new FormComponents().ShowDialog();
        }
    }
}
