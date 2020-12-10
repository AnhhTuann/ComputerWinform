﻿using System;
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
    public partial class FormCombo : Form
    {
        private List<Combo> rows = new List<Combo>();
        private List<Product> rows_product = new List<Product>();
        public FormCombo()
        {
            InitializeComponent();
        }

        private void FormCombo_Load(object sender, EventArgs e)
        {
            LoadDataCombo();
            LoadTheme();
        }


        private async void LoadDataCombo()
        {
            string response = await ApiHandler.client.GetStringAsync("combo");
            rows = JsonConvert.DeserializeObject<List<Combo>>(response);
            DataTable combos = new DataTable("combos");

            combos.Columns.Add(new DataColumn("Id"));
            combos.Columns.Add(new DataColumn("Name"));
            combos.Columns.Add(new DataColumn("Discount"));

            foreach (Combo record in rows)
            {
                DataRow row;
                row = combos.NewRow();
                row["Id"] = record.Id;
                row["Name"] = record.Name;
                row["Discount"] = record.Discount;

                combos.Rows.Add(row);
            }

            dataGridViewCombo.DataSource = combos;
            LoadProduct();
        }

        private void LoadDataComboDetail(int id)
        {
            Combo combo = rows.Find((c) => c.Id == id);
            DataTable combos = new DataTable("combos");
            combos.Columns.Add(new DataColumn("Product Id"));
            combos.Columns.Add(new DataColumn("Product Name"));
            combos.Columns.Add(new DataColumn("Price"));


                foreach (ComboDetails rec in combo.Details)
                {
                    DataRow row;
                    row = combos.NewRow();
                    row["Product Id"] = rec.Product.Id;
                    row["Product Name"] = rec.Product.Name;
                    row["Price"] = rec.Product.Price;

                    combos.Rows.Add(row);
                }
            

            dataGridViewDetails.DataSource = combos;
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
            labelCombo.ForeColor = ThemeColor.SecondaryColor;
            labelDetails.ForeColor = ThemeColor.SecondaryColor;
            labelAddProduct.ForeColor = ThemeColor.PrimaryColor;
            labelList.ForeColor = ThemeColor.PrimaryColor;

            foreach (Control btns in panelFill.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

        }


        private void dataGridViewCombo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewCombo.Rows[e.RowIndex];

                textComboId.Text = row.Cells["Id"].Value.ToString();
                textComboName.Text = row.Cells["Name"].Value.ToString();
                textDiscount.Text = row.Cells["Discount"].Value.ToString();
                LoadDataComboDetail(Int32.Parse(row.Cells["Id"].Value.ToString()));
            }
        }

        private async void LoadProduct()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            string response = await ApiHandler.client.GetStringAsync("product");
            List<Product> rows = JsonConvert.DeserializeObject<List<Product>>(response);



            foreach (Product record in rows)
            {
                comboSource.Add(record.Id, record.Name);
            }

            cbProductName.DataSource = new BindingSource(comboSource, null);
        }
        private async void addProductToList(object sender, EventArgs e)
        {
            int productId = ((KeyValuePair<int, string>)cbProductName.SelectedItem).Key;
            string productName = ((KeyValuePair<int, string>)cbProductName.SelectedItem).Value;
            
            Product product = new Product()
            {
                Id = productId,
                Name = productName
            };
            rows_product.Add(product);
            LoadListProduct(product);
        }
        
        private void LoadListProduct(Product product)
        {
            Delete.Name = "button";
            Delete.HeaderText = "Button";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true; //dont forget this line
            Product.Name = product.Name;
            dataGridViewProduct.Rows.Add(Product.Name, Delete);
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                dataGridViewProduct.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
