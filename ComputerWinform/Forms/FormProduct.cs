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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();

        }

        private async void LoadData () {
            string response = await ApiHandler.client.GetStringAsync("product");
            List<Product> rows = JsonConvert.DeserializeObject<List<Product>>(response);
            DataTable products = new DataTable("products");

            products.Columns.Add(new DataColumn("Id"));
            products.Columns.Add(new DataColumn("Name"));
            products.Columns.Add(new DataColumn("Description"));
            products.Columns.Add(new DataColumn("Price"));
            products.Columns.Add(new DataColumn("Category"));

            foreach (Product record in rows)
            {
                DataRow row;
                row = products.NewRow();
                row["Id"] = record.Id;
                row["Name"] = record.Name;
                row["Description"] = record.Description;
                row["Price"] = record.Price;
                row["Category"] = record.Category.Name;
                products.Rows.Add(row);
            }

            dataGridViewProduct.DataSource = products;
        }

        private async void FormProduct_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCategory();
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

        private async void LoadCategory()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            string response = await ApiHandler.client.GetStringAsync("category");
            List<Category> rows = JsonConvert.DeserializeObject<List<Category>>(response);
            
            

            foreach (Category record in rows)
            {
                comboSource.Add(record.Id, record.Name);
            }

            cbCategory.DataSource = new BindingSource(comboSource,null);

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {

            cbCategory.DisplayMember = "Value";
            cbCategory.ValueMember = "Key";
            int key = ((KeyValuePair<int, string>)cbCategory.SelectedItem).Key;
            string value = ((KeyValuePair<int, string>)cbCategory.SelectedItem).Value;
            Category category = new Category();
            category.Id = key;
            category.Name = value;

            Product product = new Product();
            product.Name = textProductName.Text;
            product.Description = textProductName.Text;
            product.Price = Int32.Parse( textPrice.Text);
            product.Category = category;

            var response = await ApiHandler.client.PostAsJsonAsync("product", product);
            LoadData();
        }


    }
}
