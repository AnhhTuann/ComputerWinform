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
using DTO;
using Newtonsoft.Json;

namespace ComputerWinform.Forms
{
    public partial class FormOrder : Form
    {
        private List<Receipt> rows = new List<Receipt>();
        private List<Combo> rowCombo = new List<Combo>();

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
            dataGridView1.Rows.Clear();
            DataRow row;
            Receipt receipt = rows.Find((c) => c.Id == id);
            DataTable receipts = new DataTable("receipts");
            receipts.Columns.Add(new DataColumn("Product Id"));
            receipts.Columns.Add(new DataColumn("Product Name"));
            receipts.Columns.Add(new DataColumn("Price"));
            receipts.Columns.Add(new DataColumn("Amount"));


            foreach (ReceiptDetails rec in receipt.Details)
            {
                row = receipts.NewRow();
                row["Product Id"] = rec.Product.Id;
                row["Product Name"] = rec.Product.Name;
                row["Price"] = rec.Product.Price;
                row["Amount"] = rec.Amount;


                receipts.Rows.Add(row);

                // load data for DataGridViewProduct
                Delete.Name = "button";
                Delete.HeaderText = "Button";
                Delete.Text = "Delete";
                Delete.UseColumnTextForButtonValue = true; //dont forget this line
                productname.Name = rec.Product.Name;
                productid.Name = rec.Product.Id.ToString();
                amount.Name = rec.Amount.ToString();
                dataGridView1.Rows.Add(productid.Name, productname.Name, amount.Name, Delete);
            }

            
            dataGridViewProduct.DataSource = receipts;
           
        }

        private void LoadDataReceiptCombo(int id)
        {
            dataGridView2.Rows.Clear();
            DataRow row;
            Receipt receipt = rows.Find((c) => c.Id == id);
            DataTable receipts = new DataTable("receipts");
            receipts.Columns.Add(new DataColumn("Combo Name"));
            receipts.Columns.Add(new DataColumn("Discount"));
            receipts.Columns.Add(new DataColumn("Price"));
            receipts.Columns.Add(new DataColumn("Amount"));


            foreach (ReceiptCombos rec in receipt.Combos)
            {
                row = receipts.NewRow();
                row["Combo Name"] = rec.Combo.Id;
                row["Discount"] = rec.Combo.Name;
                row["Price"] = rec.Combo.Price;
                row["Amount"] = rec.Amount;

                receipts.Rows.Add(row);

                DeleteCombo.Name = "button";
                DeleteCombo.HeaderText = "Button";
                DeleteCombo.Text = "Delete";
                DeleteCombo.UseColumnTextForButtonValue = true; //dont forget this line
                comboName.Name = rec.Combo.Name;
                comboid.Name = rec.Combo.Id.ToString();
                amountcombo.Name = rec.Amount.ToString();
                dataGridView2.Rows.Add(comboid.Name, comboName.Name, amountcombo.Name, DeleteCombo);

            }

            dataGridViewCombo.DataSource = receipts;
            
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
                dateDate.Text = row.Cells["Date"].Value.ToString();
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
                    btn.BackColor = ThemeColor.SecondaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.PrimaryColor;
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

        private void buttonLoadProduct_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void buttonLoadCombo_Click(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            int productId;
            string productName;
            if (cbProductName.Text == "")
            {
                var message = "Please input product name";
                var title = "Error";
                MessageBox.Show(message, title);
                cbProductName.Focus();
                return;
            }
            else
            {
                productId = ((KeyValuePair<int, string>)cbProductName.SelectedItem).Key;
                productName = ((KeyValuePair<int, string>)cbProductName.SelectedItem).Value;
            }

            if (textAmountProduct.Text == "")
            {
                var message = "Please input product name";
                var title = "Error";
                MessageBox.Show(message, title);
                textAmountProduct.Focus();
                return;
            }
            else {
                int amountProduct = Int32.Parse(textAmountProduct.Text);
                Product product = new Product()
                {
                    Id = productId,
                    Name = productName,
                    Amount = amountProduct
                };

                if (checkExistProduct())
                {
                    var message = "Please choice product other";
                    var title = "Product existed";
                    MessageBox.Show(message, title);
                }
                else
                {
                    LoadListProduct(product);
                }
            }
            
            
            
        }
        private bool checkExistProduct()
        {
            var flag = false;
            int productId = ((KeyValuePair<int, string>)cbProductName.SelectedItem).Key;
            for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
            {
                var Id = Int32.Parse(dataGridView1.Rows[rows].Cells[0].Value.ToString());
                if (productId == Id)
                {
                    flag = true;
                }

            }
            return flag;
        }
        private void LoadListProduct(Product product)
        {
            Delete.Name = "button";
            Delete.HeaderText = "Button";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true; //dont forget this line
            productname.Name = product.Name;
            productid.Name = product.Id.ToString();
            amount.Name = product.Amount.ToString();
            dataGridView1.Rows.Add(productid.Name, productname.Name,amount.Name, Delete);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void buttonAddCombo_Click(object sender, EventArgs e)
        {
            int comboId;
            string comboName;
            if (cbComboname.Text == "") 
            {
                var message = "Please input combo name";
                var title = "Error";
                MessageBox.Show(message, title);
                cbComboname.Focus();
                return;
            }
            else
            {
                 comboId = ((KeyValuePair<int, string>)cbComboname.SelectedItem).Key;
                 comboName = ((KeyValuePair<int, string>)cbComboname.SelectedItem).Value;
            }
            
           


            if (textAmountCombo.Text == "")
            {
                var message = "Please input combo name";
                var title = "Error";
                MessageBox.Show(message, title);
                textAmountCombo.Focus();
                return;
            }
            else
            {
                int amountCombo = Int32.Parse(textAmountCombo.Text);
                Combo combo = new Combo()
                {
                    Id = comboId,
                    Name = comboName,
                    Amount = amountCombo
                };

                if (checkExistCombo())
                {
                    var message = "Please imput amount combo";
                    var title = "Error";
                    MessageBox.Show(message, title);
                }
                else
                {
                    LoadListCombo(combo);
                }
            }
        }
        private bool checkExistCombo()
        {
            var flag = false;
            int comboId = ((KeyValuePair<int, string>)cbComboname.SelectedItem).Key;
            for (int rows = 0; rows < dataGridView2.Rows.Count - 1; rows++)
            {
                var Id = Int32.Parse(dataGridView2.Rows[rows].Cells[0].Value.ToString());
                if (comboId == Id)
                {
                    flag = true;
                }

            }
            return flag;
        }
        private void LoadListCombo(Combo combo)
        {
            DeleteCombo.Name = "button";
            DeleteCombo.HeaderText = "Button";
            DeleteCombo.Text = "Delete";
            DeleteCombo.UseColumnTextForButtonValue = true; //dont forget this line
            comboName.Name = combo.Name;
            comboid.Name = combo.Id.ToString();
            amountcombo.Name = combo.Amount.ToString();
            dataGridView2.Rows.Add(comboid.Name, comboName.Name, amountcombo.Name, DeleteCombo);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                dataGridView2.Rows.RemoveAt(e.RowIndex);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            List<Product> rows_product = new List<Product>();
            List<Combo> rows_combo = new List<Combo>();
            var x = dataGridView1.Rows.Count;
            for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
            {
                Product product = new Product()
                {
                    Id = Int32.Parse(dataGridView1.Rows[rows].Cells[0].Value.ToString()),
                    Name = dataGridView1.Rows[rows].Cells[1].Value.ToString(),
                    Amount = Int32.Parse(dataGridView1.Rows[rows].Cells[2].Value.ToString())
                };
                rows_product.Add(product);
            }
            for (int rows = 0; rows < dataGridView2.Rows.Count - 1; rows++)
            {
                Combo combo = new Combo()
                {
                    Id = Int32.Parse(dataGridView2.Rows[rows].Cells[0].Value.ToString()),
                    Name = dataGridView2.Rows[rows].Cells[1].Value.ToString(),
                    Amount = Int32.Parse(dataGridView2.Rows[rows].Cells[2].Value.ToString())
                };
                rows_combo.Add(combo);
            }
            List<ReceiptDetails> listReceiptDetails = new List<ReceiptDetails>();
            foreach (var item in rows_product)
            {
                ReceiptDetails receiptDetails = new ReceiptDetails()
                {
                    Product = new Product()
                    {
                        Id = item.Id,
                    },
                    Amount = item.Amount
                };

                listReceiptDetails.Add(receiptDetails);
            }
            List<ReceiptCombos> listReceiptCombos = new List<ReceiptCombos>();
            foreach (var item in rows_combo)
            {
                ReceiptCombos ReceiptCombos = new ReceiptCombos()
                {
                    Combo = new Combo()
                    {
                        Id = item.Id
                    },
                    Amount = item.Amount
                };
                listReceiptCombos.Add(ReceiptCombos);
            }
            int customerId = ((KeyValuePair<int, string>)cbCustomer.SelectedItem).Key;
            Receipt receipt = new Receipt()
            {
                Recipient = textName.Text,
                Address = textAddress.Text,
                Phone = textPhone.Text,
                Date = dateDate.Text,
                Status = Int32.Parse(textStatus.Text),
                Details = listReceiptDetails,
                Combos = listReceiptCombos,
                Customer = new Person()
                {
                    Id = customerId,
                }
            };
            var test = await ApiHandler.client.PostAsJsonAsync("receipt", receipt);
            LoadDataCustomer();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            List<Product> rows_product = new List<Product>();
            List<Combo> rows_combo = new List<Combo>();
            var x = dataGridView1.Rows.Count;
            for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
            {
                Product product = new Product()
                {
                    Id = Int32.Parse(dataGridView1.Rows[rows].Cells[0].Value.ToString()),
                    Name = dataGridView1.Rows[rows].Cells[1].Value.ToString(),
                    Amount = Int32.Parse(dataGridView1.Rows[rows].Cells[2].Value.ToString())
                };
                rows_product.Add(product);
            }
            for (int rows = 0; rows < dataGridView2.Rows.Count - 1; rows++)
            {
                Combo combo = new Combo()
                {
                    Id = Int32.Parse(dataGridView2.Rows[rows].Cells[0].Value.ToString()),
                    Name = dataGridView2.Rows[rows].Cells[1].Value.ToString(),
                    Amount = Int32.Parse(dataGridView2.Rows[rows].Cells[2].Value.ToString())
                };
                rows_combo.Add(combo);
            }
            List<ReceiptDetails> listReceiptDetails = new List<ReceiptDetails>();
            foreach (var item in rows_product)
            {
                ReceiptDetails receiptDetails = new ReceiptDetails()
                {
                    Product = new Product()
                    {
                        Id = item.Id,
                    },
                    Amount = item.Amount
                };

                listReceiptDetails.Add(receiptDetails);
            }
            List<ReceiptCombos> listReceiptCombos = new List<ReceiptCombos>();
            foreach (var item in rows_combo)
            {
                ReceiptCombos ReceiptCombos = new ReceiptCombos()
                {
                    Combo = new Combo()
                    {
                        Id = item.Id
                    },
                    Amount = item.Amount
                };
                listReceiptCombos.Add(ReceiptCombos);
            }
            int customerId = ((KeyValuePair<int, string>)cbCustomer.SelectedItem).Key;
            Receipt receipt = new Receipt()
            {
                Id = Int32.Parse(textId.Text),
                Recipient = textName.Text,
                Address = textAddress.Text,2
                Phone = textPhone.Text,
                Date = dateDate.Text,
                Status = Int32.Parse(textStatus.Text),
                Details = listReceiptDetails,
                Combos = listReceiptCombos,
                Customer = new Person()
                {
                    Id = customerId,
                }
            };
            var test = await ApiHandler.client.PutAsJsonAsync("receipt", receipt);
            LoadDataCustomer();
        }

        private async void btnDel_Click(object sender, EventArgs e)
        {
            var receiptId = Int32.Parse(textId.Text);
            await ApiHandler.client.DeleteAsync("receipt/" + receiptId);
            LoadDataCustomer();
        }
    }

}
