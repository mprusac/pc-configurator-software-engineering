using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Konfigo.Model;
using Konfigo.Repository;

namespace Konfigo
{
    public partial class FormCreateConfiguration : Form
    {
        private List<Component> selectedComponents = new List<Component>();

        public FormCreateConfiguration()
        {
            InitializeComponent();
            LoadTypes();
        }

        private void LoadTypes()
        {
            var types = ComponentRepository.GetAllTypes();
            foreach (var type in types)
            {
                var btn = new Button();
                btn.Text = type;
                btn.Width = 120;
                btn.Height = 40;
                btn.Click += (s, e) => LoadComponentsByType(type);
                flpTypes.Controls.Add(btn);
            }
        }

        private void LoadComponentsByType(string type)
        {
            var filtered = ComponentRepository.GetComponentsByType(type);
            dgvComponents.DataSource = filtered;
            dgvComponents.Columns["Name"].HeaderText = "Naziv";
            dgvComponents.Columns["Price"].HeaderText = "Cijena (€)";
            dgvComponents.Columns["StockQuantity"].HeaderText = "Na skladištu";
            dgvComponents.Columns["Manufacturer"].HeaderText = "Proizvođač";
            dgvComponents.Columns["Specifications"].HeaderText = "Specifikacije";
            dgvComponents.Columns["TypeName"].HeaderText = "Tip";
            dgvComponents.Columns["Id"].Visible = false;
            dgvComponents.Columns["ComponentTypeId"].Visible = false;
            dgvComponents.CellDoubleClick -= dgvComponents_CellDoubleClick;
            dgvComponents.CellDoubleClick += dgvComponents_CellDoubleClick;

        }

        private void AddComponent(Component component)
        {
            selectedComponents.RemoveAll(c => c.ComponentTypeId == component.ComponentTypeId);
            selectedComponents.Add(component);
            RefreshSelectedList();
        }


        private void RefreshSelectedList()
        {
            dgvSelected.DataSource = null;
            dgvSelected.DataSource = selectedComponents;

   
            dgvSelected.Columns["Name"].HeaderText = "Naziv";
            dgvSelected.Columns["Price"].HeaderText = "Cijena (€)";
            dgvSelected.Columns["StockQuantity"].HeaderText = "Na skladištu";
            dgvSelected.Columns["Manufacturer"].HeaderText = "Proizvođač";
            dgvSelected.Columns["Specifications"].HeaderText = "Specifikacije";
            dgvSelected.Columns["TypeName"].HeaderText = "Tip";

            
            dgvSelected.Columns["Id"].Visible = false;
            dgvSelected.Columns["ComponentTypeId"].Visible = false;

           
            lblTotal.Text = selectedComponents.Sum(c => c.Price).ToString("0.00") + " €";
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            var config = new Configuration
            {
                CustomerId = 1,
                DateCreated = DateTime.Now,
                TotalPrice = selectedComponents.Sum(c => c.Price),
                Components = selectedComponents
            };

            ConfigurationRepository.Save(config);
            MessageBox.Show("Konfiguracija je spremljena.");

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var form = new FrmEmail(selectedComponents);
            form.ShowDialog();
        }

        private void FormCreateConfiguration_Load(object sender, EventArgs e)
        {
            dgvComponents.RowHeadersVisible = false;
            dgvSelected.RowHeadersVisible = false;
        }

        private void dgvComponents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var component = dgvComponents.Rows[e.RowIndex].DataBoundItem as Component;
                if (component != null)
                {
                    AddComponent(component);
                }
            }
        }

    }
}
