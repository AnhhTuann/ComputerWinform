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


        private async void FormProduct_Load(object sender, EventArgs e)
        {
            string response = await ApiHandler.client.GetStringAsync("product");
            List<Product> rows = JsonConvert.DeserializeObject<List<Product>>(response);
            DataTable products = new DataTable("products");

            products.Columns.Add(new DataColumn("Id"));
            products.Columns.Add(new DataColumn("Name"));
            products.Columns.Add(new DataColumn("Description"));
            products.Columns.Add(new DataColumn("Price"));
            products.Columns.Add(new DataColumn("Amount"));
            products.Columns.Add(new DataColumn("Category"));

            foreach (Product record in rows)
            {
                DataRow row;
                row = products.NewRow();
                row["Id"] = record.Id;
                row["Name"] = record.Name;
                row["Description"] = record.Description;
                row["Price"] = record.Price;
                row["Amount"] = record.Amount;
                row["Category"] = record.Category.Name;
                products.Rows.Add(row);
            }

            dataGridViewProduct.DataSource = products;
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
