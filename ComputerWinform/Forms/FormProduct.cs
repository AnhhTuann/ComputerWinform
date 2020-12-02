using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerWinform.Forms
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private async void FormProduct_Load(object sender, EventArgs e)
        {
            string response = await ApiHandler.client.GetStringAsync("category");
            List<Category> rows = JsonConvert.DeserializeObject<List<Category>>(response);
            DataTable categories = new DataTable("categories");

            categories.Columns.Add(new DataColumn("Id"));
            categories.Columns.Add(new DataColumn("Name"));

            foreach (Category record in rows)
            {
                DataRow row;
                row = categories.NewRow();
                row["Id"] = record.Id;
                row["Name"] = record.Name;
                categories.Rows.Add(row);
            }

            dataGridView1.DataSource = categories;
        }
    }
}
