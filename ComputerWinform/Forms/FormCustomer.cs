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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
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
            labelCustomer.ForeColor = ThemeColor.SecondaryColor;
            labelList.ForeColor = ThemeColor.PrimaryColor;
        }


        private async void LoadData()
        {
            string response = await ApiHandler.client.GetStringAsync("customer");
            List<Person> rows = JsonConvert.DeserializeObject<List<Person>>(response);
            DataTable customers = new DataTable("cutomers");

            customers.Columns.Add(new DataColumn("Id"));
            customers.Columns.Add(new DataColumn("Name"));
            customers.Columns.Add(new DataColumn("Email"));
            customers.Columns.Add(new DataColumn("Address"));
            customers.Columns.Add(new DataColumn("Phone"));

            foreach (Person record in rows)
            {
                DataRow row;
                row = customers.NewRow();
                row["Id"] = record.Id;
                row["Name"] = record.Name;
                row["Email"] = record.Email;
                row["Address"] = record.Address;
                row["Phone"] = record.Phone;

                customers.Rows.Add(row);
            }

            dataGridViewCustomer.DataSource = customers;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textId.Text = "";
            textName.Text = "";
            textEmail.Text = "";
            textAddress.Text = "";
            textPhone.Text = "";
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewCustomer.Rows[e.RowIndex];
                textId.Text = row.Cells["Id"].Value.ToString();
                textName.Text = row.Cells["Name"].Value.ToString();
                textEmail.Text = row.Cells["Email"].Value.ToString();
                textAddress.Text = row.Cells["Address"].Value.ToString();
                textPhone.Text = row.Cells["Phone"].Value.ToString();

            }
        }

    }
}
