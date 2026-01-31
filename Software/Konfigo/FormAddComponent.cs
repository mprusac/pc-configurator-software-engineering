using System;
using System.Data;
using System.Windows.Forms;
using Konfigo;


namespace Konfigo
{
    public partial class FormAddComponent : Form
    {
        public FormAddComponent()
        {
            InitializeComponent();
        }

        private void FormAddComponent_Load(object sender, EventArgs e)
        {
           
            DB.OpenConnection();
            var dr = DB.GetDataReader("SELECT Id, Name FROM dbo.ComponentTypes");

            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            DB.CloseConnection();

            cmbType.DisplayMember = "Name";
            cmbType.ValueMember = "Id";
            cmbType.DataSource = dt;

            numPrice.Maximum = 100000;
            numPrice.Minimum = 0;
            numPrice.Value = 0;
            numPrice.DecimalPlaces = 2;
            numPrice.Increment = 0.10M;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Naziv komponente je obavezan.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbType.SelectedIndex == -1)
            {
                MessageBox.Show("Odaberite tip komponente.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtManufacturer.Text))
            {
                MessageBox.Show("Proizvođač je obavezan.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSpecifications.Text))
            {
                MessageBox.Show("Specifikacije su obavezne.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numPrice.Value <= 0)
            {
                MessageBox.Show("Cijena mora biti veća od 0.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numStock.Value < 0)
            {
                MessageBox.Show("Zaliha ne smije biti negativna.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


                       DB.OpenConnection();

            string name = txtName.Text.Trim();
            int typeId = (int)cmbType.SelectedValue;
            decimal price = numPrice.Value;
            int stock = (int)numStock.Value;
            



            string manufacturer = txtManufacturer.Text.Trim();
            string specifications = txtSpecifications.Text.Trim();




            string query = $@"
    INSERT INTO Components (Name, ComponentTypeId, Price, StockQuantity, Manufacturer, Specifications)
    VALUES ('{name}', {typeId}, {price.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {stock}, '{manufacturer}', '{specifications}')
";



            DB.ExecuteCommand(query);
            DB.CloseConnection();

            MessageBox.Show("Komponenta je uspješno dodana.");
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSpecifications_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
