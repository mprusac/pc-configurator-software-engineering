using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Konfigo;
using Konfigo.Model;
using Konfigo.Repository;

namespace Konfigo
{
    public partial class FormComponents : Form
    {
        public FormComponents()
        {
            InitializeComponent();
        }

        private void FormComponents_Load(object sender, EventArgs e)
        {

            dgvComponents.RowHeadersVisible = false;
            if (AppUser.Role == UserRole.Customer)
            {
                btnAdd.Visible = false;
                btnDelete.Visible = false;

                dgvComponents.ReadOnly = true;

                dgvComponents.ClearSelection();
                dgvComponents.DefaultCellStyle.SelectionBackColor = dgvComponents.BackgroundColor;
                dgvComponents.DefaultCellStyle.SelectionForeColor = dgvComponents.ForeColor;
                dgvComponents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvComponents.MultiSelect = false;
                dgvComponents.AllowUserToAddRows = false;

            }

            btnRefresh.PerformClick();

                        DB.OpenConnection();

            var dr = DB.GetDataReader("SELECT Id, Name FROM ComponentTypes");

            while (dr.Read())
            {
                int id = (int)dr["Id"];
                string name = dr["Name"].ToString();

                Button btn = new Button();
                btn.Text = name;
                btn.Tag = id;
                btn.AutoSize = true;
                btn.Click += BtnFilterByType_Click;

                flpTypes.Controls.Add(btn);
            }

            dr.Close();
            DB.CloseConnection();




        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var lista = ComponentRepository.GetAllForView();
            dgvComponents.DataSource = new BindingSource { DataSource = lista };

            dgvComponents.Columns["ComponentTypeId"].Visible = false;



            dgvComponents.Columns["Name"].HeaderText = "Naziv";
            dgvComponents.Columns["TypeName"].HeaderText = "Tip";
            dgvComponents.Columns["Price"].HeaderText = "Cijena (€)";
            dgvComponents.Columns["StockQuantity"].HeaderText = "Količina";
            dgvComponents.Columns["Manufacturer"].HeaderText = "Proizvođač";
            dgvComponents.Columns["Specifications"].HeaderText = "Specifikacije";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddComponent form = new FormAddComponent();
            form.ShowDialog();
            btnRefresh.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvComponents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite komponentu za brisanje.");
                return;
            }

           
            int selectedId = (int)dgvComponents.SelectedRows[0].Cells["Id"].Value;
            string name = dgvComponents.SelectedRows[0].Cells["Name"].Value.ToString();

            var potvrda = MessageBox.Show($"Obrisati komponentu '{name}'?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (potvrda == DialogResult.Yes)
            {
                ComponentRepository.DeleteById(selectedId);
                btnRefresh.PerformClick();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            var lista = ComponentRepository.GetAllForView();

           


            var result = lista
                .Where(c => c.Name.ToLower().Contains(keyword))
                .ToList();

            dgvComponents.DataSource = new BindingSource { DataSource = result };

            dgvComponents.Columns["ComponentTypeId"].Visible = false;

        }

        private void BtnFilterByType_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            int typeId = (int)btn.Tag;

            var list = ComponentRepository.GetAllForView()
                .Where(c => c.ComponentTypeId == typeId)
                .ToList();

            dgvComponents.DataSource = new BindingSource { DataSource = list };


            dgvComponents.Columns["Manufacturer"].HeaderText = "Proizvođač";
            dgvComponents.Columns["Specifications"].HeaderText = "Specifikacije";
            dgvComponents.Columns["TypeName"].HeaderText = "Tip";
        }



        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            var list = ComponentRepository.GetAllForView();
            dgvComponents.DataSource = new BindingSource { DataSource = list };

            dgvComponents.Columns["ComponentTypeId"].Visible = false;


            dgvComponents.Columns["Manufacturer"].HeaderText = "Proizvođač";
            dgvComponents.Columns["Specifications"].HeaderText = "Specifikacije";
            dgvComponents.Columns["TypeName"].HeaderText = "Tip";
        }

        private void dgvComponents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedId = (int)dgvComponents.Rows[e.RowIndex].Cells["Id"].Value;
                var form = new FormEditComponent(selectedId);
                form.ShowDialog();
                LoadComponents();
            }
        }

        private void LoadComponents()
        {
            dgvComponents.DataSource = null;
            dgvComponents.DataSource = ComponentRepository.GetAllForView();

            dgvComponents.Columns["Id"].Visible = false;
            dgvComponents.Columns["ComponentTypeId"].Visible = false;

            dgvComponents.Columns["Name"].HeaderText = "Naziv";
            dgvComponents.Columns["Price"].HeaderText = "Cijena (€)";
            dgvComponents.Columns["StockQuantity"].HeaderText = "Na skladištu";
            dgvComponents.Columns["Manufacturer"].HeaderText = "Proizvođač";
            dgvComponents.Columns["Specifications"].HeaderText = "Specifikacije";
            dgvComponents.Columns["TypeName"].HeaderText = "Tip";

            dgvComponents.RowHeadersVisible = false;
            dgvComponents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }



    }
}
