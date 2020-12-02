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
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private async void FormCategory_LoadAsync(object sender, EventArgs e)
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

            dataGridViewCatetgory.DataSource = categories;
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
            labelProduct.ForeColor = ThemeColor.SecondaryColor;
        }
    }
}
