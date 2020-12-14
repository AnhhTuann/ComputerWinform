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
        }

        private void FormProduct_Load(object sender, EventArgs e)
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
            labelList.ForeColor = ThemeColor.PrimaryColor;
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
            if(checkValueForm())
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
            

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png; *jfif)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.jfif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageName = openFileDialog1.FileName;
                Bitmap image = new Bitmap(imageName);

                using (var stream = new MemoryStream())
                {
                    image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    selectedImage = stream.ToArray();
                    pbImage.Image = image;
                    labelImageName.Text = imageName;
                }
            }
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 )
            {
                DataGridViewRow row = this.dataGridViewProduct.Rows[e.RowIndex];

                textProductId.Text = row.Cells["Id"].Value.ToString();
                textProductName.Text = row.Cells["Name"].Value.ToString();
                textDescription.Text = row.Cells["Description"].Value.ToString();
                textPrice.Text = row.Cells["Price"].Value.ToString();
                cbCategory.Text = row.Cells["Category"].Value.ToString();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textProductId.Text = "";
            textProductName.Text = "";
            textDescription.Text = "";
            textPrice.Text = "";
            cbCategory.Text = "";
        }

        private async void btnDel_Click(object sender, EventArgs e)
        {
            var productId = Int32.Parse(textProductId.Text);
            
            await ApiHandler.client.DeleteAsync("product/"+ productId);
            LoadData();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if(checkValueForm())
            {
                int categoryId = ((KeyValuePair<int, string>)cbCategory.SelectedItem).Key;
                string categoryName = ((KeyValuePair<int, string>)cbCategory.SelectedItem).Value;


                var product = new Product()
                {
                    Id = Int32.Parse(textProductId.Text),
                    Name = textProductName.Text,
                    Description = textDescription.Text,
                    Price = Int32.Parse(textPrice.Text),
                    Image = "",
                    Category = new Category()
                    {
                        Id = categoryId,
                        Name = categoryName
                    }

                };
                await ApiHandler.client.PutAsJsonAsync("product", product);
                LoadData();
            }
        }

        private bool checkValueForm()
        {
            string message = "";
            string title = "Error";
            
            if (textProductName.Text == "")
            {
                message = "Please input product name";
                MessageBox.Show(message, title);
                textProductName.Focus();
                return false;
            }
            if(textDescription.Text == "")
            {
                message = "Please input product description";
                MessageBox.Show(message, title);
                textDescription.Focus();
                return false;
            }
            if (textPrice.Text == "")
            {
                message = "Please input product price";
                MessageBox.Show(message, title);
                textPrice.Focus();
                return false;
            }
            if (cbCategory.Text == "")
            {
                message = "Please select category";
                MessageBox.Show(message, title);
                cbCategory.Focus();
                return false;
            }

            return true;
        }


    }
}
