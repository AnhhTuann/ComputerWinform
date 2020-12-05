using DTO;
using Newtonsoft.Json;
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


namespace ComputerWinform.Forms
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private async void LoadData ()
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
            AutoSize = true;
            dataGridViewCatetgory.DataSource = categories;
        }

        private void FormCategory_LoadAsync(object sender, EventArgs e)
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
            labelProduct.ForeColor = ThemeColor.SecondaryColor;
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkValueForm())
            {
                Category category = new Category();
                category.Name = textCategoryName.Text;
                var response = await ApiHandler.client.PostAsJsonAsync("category", category);
                LoadData();
            }
            
        }

        private async void btnDel_Click(object sender, EventArgs e)
        {
            var categoryId = Int32.Parse(textCategoryId.Text);
            await ApiHandler.client.DeleteAsync("category/" + categoryId);
            LoadData();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textCategoryName.Text = "";
            textSearch.Text = "";
        }

        private void dataGridViewCatetgory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewCatetgory.Rows[e.RowIndex];

                textCategoryId.Text = row.Cells["Id"].Value.ToString();
                textCategoryName.Text = row.Cells["Name"].Value.ToString();
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if(checkValueForm())
            {
                var category = new Category()
                {
                    Id = Int32.Parse(textCategoryId.Text),
                    Name = textCategoryName.Text,
                };
                await ApiHandler.client.PutAsJsonAsync("category", category);
                LoadData();
            }
        }
        private bool checkValueForm()
        {
            string message = "";
            string title = "Error";

            if (textCategoryName.Text == "")
            {
                message = "Please input category name";
                MessageBox.Show(message, title);
                textCategoryName.Focus();
                return false;
            }
            return true;
        }
    }
}
