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
    public partial class FormOrder : Form
    {
        private List<Receipt> rows = new List<Receipt>();
        public FormOrder()
        {
            InitializeComponent();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            LoadDataCustomer();
            LoadTheme();
        }

        private async void LoadDataCustomer()
        {

            string response = await ApiHandler.client.GetStringAsync("receipt");
            rows = JsonConvert.DeserializeObject<List<Receipt>>(response);
            DataTable customers = new DataTable("customers");

            customers.Columns.Add(new DataColumn("Id"));
            customers.Columns.Add(new DataColumn("Name"));
            customers.Columns.Add(new DataColumn("Address Customer"));
            customers.Columns.Add(new DataColumn("Phone Customer"));
            customers.Columns.Add(new DataColumn("Recipient"));
            customers.Columns.Add(new DataColumn("Address Recipient"));
            customers.Columns.Add(new DataColumn("Phone Recipient"));
            customers.Columns.Add(new DataColumn("Status"));
            customers.Columns.Add(new DataColumn("Date"));
            customers.Columns.Add(new DataColumn("Total cost"));


            foreach (Receipt record in rows)
            {
                DataRow row;
                row = customers.NewRow();
                row["Id"] = record.Id;
                row["Name"] = record.Customer.Name;
                row["Address Customer"] = record.Customer.Address;
                row["Phone Customer"] = record.Customer.Phone;
                row["Recipient"] = record.Recipient;
                row["Address Recipient"] = record.Address;
                row["Phone Recipient"] = record.Phone;
                row["Status"] = record.Status;
                row["Date"] = record.Date;
                row["Total cost"] = record.TotalCost;

                customers.Rows.Add(row);
            }
            AutoSize = true;
            dataGridViewCustomer.DataSource = customers;
            LoadCustomer();
        }


        private void LoadDataReceiptDetail(int id)
        {
            DataRow row;
            Receipt receipt = rows.Find((c) => c.Id == id);
            DataTable receipts = new DataTable("receipts");
            receipts.Columns.Add(new DataColumn("Product Id"));
            receipts.Columns.Add(new DataColumn("Product Name"));
            receipts.Columns.Add(new DataColumn("Price"));
            
            foreach (ReceiptDetails rec in receipt.Details)
            {
                row = receipts.NewRow();
                row["Product Id"] = rec.Product.Id;
                row["Product Name"] = rec.Product.Name;
                row["Price"] = rec.Product.Price;

                receipts.Rows.Add(row);

            }


            dataGridViewProduct.DataSource = receipts;
            LoadProduct();
        }

        private void LoadDataReceiptCombo(int id)
        {
            DataRow row;
            Receipt receipt = rows.Find((c) => c.Id == id);
            DataTable receipts = new DataTable("receipts");
            receipts.Columns.Add(new DataColumn("Combo Name"));
            receipts.Columns.Add(new DataColumn("Discount"));
            receipts.Columns.Add(new DataColumn("Price"));

            foreach (ReceiptCombos rec in receipt.Combos)
            {
                row = receipts.NewRow();
                row["Combo Name"] = rec.Combo.Id;
                row["Discount"] = rec.Combo.Name;
                row["Price"] = rec.Combo.Price;

                receipts.Rows.Add(row);

            }


            dataGridViewCombo.DataSource = receipts;
            LoadCombo();
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               DataGridViewRow row = this.dataGridViewCustomer.Rows[e.RowIndex];
                textId.Text = row.Cells["Id"].Value.ToString();
                textName.Text = row.Cells["Recipient"].Value.ToString();
                textAddress.Text = row.Cells["Address Recipient"].Value.ToString();
                textPhone.Text = row.Cells["Phone Recipient"].Value.ToString();
                textStatus.Text = row.Cells["Status"].Value.ToString();
                //dateDate.Text = row.Cells["Date"].Value.ToString();

                LoadDataReceiptDetail(Int32.Parse(row.Cells["Id"].Value.ToString()));
                LoadDataReceiptCombo(Int32.Parse(row.Cells["Id"].Value.ToString()));
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

        private async void LoadCombo()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            string response = await ApiHandler.client.GetStringAsync("combo");
            List<Combo> rows = JsonConvert.DeserializeObject<List<Combo>>(response);



            foreach (Combo record in rows)
            {
                comboSource.Add(record.Id, record.Name);
            }

            cbComboname.DataSource = new BindingSource(comboSource, null);
   
        }

        private async void LoadCustomer()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            string response = await ApiHandler.client.GetStringAsync("customer");
            List<Person> rows = JsonConvert.DeserializeObject<List<Person>>(response);



            foreach (Person record in rows)
            {
                comboSource.Add(record.Id, record.Name);
            }

            cbCustomer.DataSource = new BindingSource(comboSource, null);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

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
            labelButton.ForeColor = ThemeColor.SecondaryColor;
            labelOrder.ForeColor = ThemeColor.SecondaryColor;
            labelCombo.ForeColor = ThemeColor.PrimaryColor;
            labelProduct.ForeColor = ThemeColor.PrimaryColor;
            labelReceipt.ForeColor = ThemeColor.PrimaryColor;

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
    }

}
