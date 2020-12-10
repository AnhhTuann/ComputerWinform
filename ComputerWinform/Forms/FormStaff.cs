using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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
            staffs.Columns.Add(new DataColumn("Password"));
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
                row["Password"] = record.Password;
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
            textPass.Text = "";
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



        private bool checkValueForm()
        {
            string message = "";
            string title = "Error";

            if (textName.Text == "")
            {
                message = "Please input customer name";
                MessageBox.Show(message, title);
                textName.Focus();
                return false;
            }
            else if (textEmail.Text == "")
            {
                message = "Please input email";
                MessageBox.Show(message, title);
                textEmail.Focus();
                return false;
            }
            else if (textAddress.Text == "")
            {
                message = "Please input address";
                MessageBox.Show(message, title);
                textAddress.Focus();
                return false;
            }
            else if (textPass.Text == "")
            {
                message = "Please input password";
                MessageBox.Show(message, title);
                textPass.Focus();
                return false;
            }
            else if (textPhone.Text == "")
            {
                message = "Please input phone number";
                MessageBox.Show(message, title);
                textPhone.Focus();
                return false;
            }
            return true;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            cbRole.ValueMember = "Key";
            int roleId = ((KeyValuePair<int, string>)cbRole.SelectedItem).Key;
            cbRole.DisplayMember = "Value";
            string roleName = ((KeyValuePair<int, string>)cbRole.SelectedItem).Value;

            Staff staff = new Staff();
            staff.Name = textName.Text;
            staff.Email = textEmail.Text;
            staff.Password = textPass.Text;
            staff.Address = textAddress.Text;
            staff.Phone = textPhone.Text;

            staff.Role = new Role()
            {
                Id = roleId,
                Name = roleName
            };

            var response = await ApiHandler.client.PostAsJsonAsync("staff", staff);
            LoadData();
           
        }

        private void buttonRefresh_Click_1(object sender, EventArgs e)
        {
            textName.Text = "";
            textEmail.Text = "";
            textPass.Text = "";
            textAddress.Text = "";
            textPhone.Text = "";
            cbRole.Text = "";
            textSearch.Text = "";
        }
    }
}
