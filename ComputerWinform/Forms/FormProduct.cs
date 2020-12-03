using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ComputerWinform.Forms
{
    public partial class FormProduct : Form
    {
        private string imageName;
        private byte[] selectedImage;

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
            MultipartFormDataContent form = new MultipartFormDataContent();

            cbCategory.DisplayMember = "Value";
            cbCategory.ValueMember = "Key";
            int categoryId = ((KeyValuePair<int, string>)cbCategory.SelectedItem).Key;
            string categoryName = ((KeyValuePair<int, string>)cbCategory.SelectedItem).Value;

            form.Add(new StringContent(textProductName.Text), "name");
            form.Add(new StringContent(textDescription.Text), "description");
            form.Add(new StringContent(textPrice.Text), "price");
            form.Add(new StringContent(categoryId.ToString()), "category[id]");
            form.Add(new StringContent(categoryName), "category[name]");
            form.Add(new StreamContent(new MemoryStream(selectedImage)), "productImage", imageName);

            await ApiHandler.client.PostAsync("product", form);
            LoadData();
        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageName = openFileDialog1.FileName;
                Bitmap image = new Bitmap(imageName);

                using (var stream = new MemoryStream())
                {
                    image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    selectedImage = stream.ToArray();
                    labelImageName.Text = imageName;
                }
            }
        }
    }
}
