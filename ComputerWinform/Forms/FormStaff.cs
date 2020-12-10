using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Newtonsoft.Json;

namespace ComputerWinform.Forms
{
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
        }


        private void dataGridViewStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewStaff.Rows[e.RowIndex];
                textId.Text = row.Cells["Id"].Value.ToString();
                textName.Text = row.Cells["Name"].Value.ToString();
                textEmail.Text = row.Cells["Email"].Value.ToString();
                textAddress.Text = row.Cells["Address"].Value.ToString();
                textPhone.Text = row.Cells["Phone"].Value.ToString();
                cbRole.Text = row.Cells["Role"].Value.ToString();
            }
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadTheme();
        }


        private void LoadTheme()
        {
            foreach (Control btns in panelBtn.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            labelButton.ForeColor = ThemeColor.PrimaryColor;
            labelStaff.ForeColor = ThemeColor.SecondaryColor;
            labelList.ForeColor = ThemeColor.PrimaryColor;
        }


        private async void LoadData()
        {
            string response = await ApiHandler.client.GetStringAsync("staff");
            List<Staff> rows = JsonConvert.DeserializeObject<List<Staff>>(response);
            DataTable staffs = new DataTable("staffs");

            staffs.Columns.Add(new DataColumn("Id"));
            staffs.Columns.Add(new DataColumn("Name"));
            staffs.Columns.Add(new DataColumn("Email"));
            staffs.Columns.Add(new DataColumn("Address"));
            staffs.Columns.Add(new DataColumn("Phone"));
            staffs.Columns.Add(new DataColumn("Role"));

            foreach (Staff record in rows)
            {
                DataRow row;
                row = staffs.NewRow();
                row["Id"] = record.Id;
                row["Name"] = record.Name;
                row["Email"] = record.Email;
                row["Address"] = record.Address;
                row["Phone"] = record.Phone;
                row["Role"] = record.Role.Name;

                staffs.Rows.Add(row);
            }

            dataGridViewStaff.DataSource = staffs;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textId.Text = "";
            textName.Text = "";
            textEmail.Text = "";
            textAddress.Text = "";
            textPhone.Text = "";
            cbRole.Text = "";
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewStaff.Rows[e.RowIndex];
                textId.Text = row.Cells["Id"].Value.ToString();
                textName.Text = row.Cells["Name"].Value.ToString();
                textEmail.Text = row.Cells["Email"].Value.ToString();
                textAddress.Text = row.Cells["Address"].Value.ToString();
                textPhone.Text = row.Cells["Phone"].Value.ToString();
                cbRole.Text = row.Cells["Role"].Value.ToString();
            }
        }

    }
}
