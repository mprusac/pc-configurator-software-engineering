using System;
using System.Data;
using System.Windows.Forms;
using Konfigo;

namespace Konfigo
{
    public partial class FormEditComponent : Form
    {
        private int componentId;

        public FormEditComponent(int id)
        {
            InitializeComponent();
            componentId = id;
        }

        private void FormEditComponent_Load(object sender, EventArgs e)
        {
            
           
            DB.OpenConnection();
            var drType = DB.GetDataReader("SELECT Id, Name FROM dbo.ComponentTypes");
            DataTable dtType = new DataTable();
            dtType.Load(drType);
            drType.Close();

            cmbType.DisplayMember = "Name";
            cmbType.ValueMember = "Id";
            cmbType.DataSource = dtType;

       
            var dr = DB.GetDataReader($"SELECT * FROM Components WHERE Id = {componentId}");
            if (dr.Read())
            {
                txtName.Text = dr["Name"].ToString();
                cmbType.SelectedValue = (int)dr["ComponentTypeId"];

                
                numPrice.Minimum = 0;
                numPrice.Maximum = 100000;
                numPrice.DecimalPlaces = 2;
                numPrice.Increment = 0.10M;

               
                numPrice.Value = Convert.ToDecimal(dr["Price"]);
                numStock.Value = Convert.ToInt32(dr["StockQuantity"]);

                txtManufacturerr.Text = dr["Manufacturer"].ToString();
                txtSpecificationss.Text = dr["Specifications"].ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Naziv je obavezan.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            
            DB.OpenConnection();

            string manufacturer = txtManufacturerr.Text.Trim();
            string specifications = txtSpecificationss.Text.Trim();
            string name = txtName.Text.Trim();
            int typeId = (int)cmbType.SelectedValue;
            decimal price = numPrice.Value;
            int stock = (int)numStock.Value;
          


            string query = $@"
UPDATE Components
SET Name = '{name}',
    ComponentTypeId = {typeId},
    Price = {price.ToString(System.Globalization.CultureInfo.InvariantCulture)},
    StockQuantity = {stock},
    Manufacturer = '{manufacturer}',
    Specifications = '{specifications}',
    
WHERE Id = {componentId}

";


            DB.ExecuteCommand(query);
            DB.CloseConnection();

            MessageBox.Show("Komponenta ažurirana.");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numGroup_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
