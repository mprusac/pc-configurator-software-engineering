using Konfigo.Model;
using Konfigo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Konfigo
{
    public partial class FormSavedConfigurations : Form
    {
        private List<Configuration> konfiguracije;

        public FormSavedConfigurations()
        {
            InitializeComponent();
        }

        private void FormSavedConfigurations_Load(object sender, EventArgs e)
        {
            dgvConfigurations.RowHeadersVisible = false;

            konfiguracije = ConfigurationRepository.GetAll();
            dgvConfigurations.DataSource = konfiguracije.Select(k => new
            {
                k.Id,
                k.TotalPrice,
                k.DateCreated
            }).ToList();

            dgvConfigurations.Columns["Id"].HeaderText = "ID";
            dgvConfigurations.Columns["TotalPrice"].HeaderText = "Ukupna cijena (€)";
            dgvConfigurations.Columns["DateCreated"].HeaderText = "Datum kreiranja";
        }

        private void dgvConfigurations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = (int)dgvConfigurations.Rows[e.RowIndex].Cells["Id"].Value;
            var konf = konfiguracije.FirstOrDefault(k => k.Id == id);

            if (konf != null)
            {
                string prikaz = "Konfiguracija #" + konf.Id + "\n\n";
                foreach (var c in konf.Components)
                {
                    prikaz += $"- {c.Name} ({c.Price:0.00} €)\n";
                }
                prikaz += "\nUkupno: " + konf.TotalPrice.ToString("0.00") + " €";
                MessageBox.Show(prikaz, "Detalji konfiguracije");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
