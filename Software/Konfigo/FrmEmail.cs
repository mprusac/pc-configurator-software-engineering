using Konfigo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Konfigo
{
    public partial class FrmEmail : Form
    {
        private List<Component> konfiguracija;

        public FrmEmail(List<Component> konfiguracija)
        {
            InitializeComponent();
            this.konfiguracija = konfiguracija;
        }

        private void FrmEmail_Load(object sender, EventArgs e)
        {
          
            dgv.DataSource = konfiguracija;
            lblUkupno.Text = "Ukupno: " + konfiguracija.Sum(c => c.Price).ToString("0.00") + " €";
            dgv.Columns["Id"].HeaderText = "Šifra";
            dgv.Columns["Name"].HeaderText = "Naziv";
            dgv.Columns["ComponentTypeId"].HeaderText = "Vrsta komponente";
            dgv.Columns["Price"].HeaderText = "Cijena (€)";


        }



        private void btnPosalji_Click(object sender, EventArgs e)
        {
            string primatelj = txtPrimatelj.Text.Trim();

            if (string.IsNullOrWhiteSpace(primatelj))
            {
                MessageBox.Show("Unesite adresu primatelja.");
                return;
            }

            var body = new StringBuilder();
            body.AppendLine("E-mail uspješno poslan!");
            body.AppendLine("Primatelj: " + primatelj);
            body.AppendLine();
            body.AppendLine("Konfiguracija:");
            foreach (var c in konfiguracija)
            {
                body.AppendLine($"- {c.Name} ({c.Price:0.00} €)");
            }
            body.AppendLine();
            body.AppendLine("Ukupno: " + konfiguracija.Sum(c => c.Price).ToString("0.00") + " €");

            MessageBox.Show(body.ToString(), "E-mail konfiguracije", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

    }
}

