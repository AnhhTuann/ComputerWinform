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
    public partial class FormStorage : Form
    {
        private List<Ticket> rows = new List<Ticket>();
        public FormStorage()
        {
            InitializeComponent();
        }

        private void FormStorage_Load(object sender, EventArgs e)
        {
            LoadDataTicket();
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
            labelButton.ForeColor = ThemeColor.PrimaryColor;
            labelStorage.ForeColor = ThemeColor.SecondaryColor;
            labelAddProduct.ForeColor = ThemeColor.PrimaryColor;
            labelDetail.ForeColor = ThemeColor.SecondaryColor;
            labelList.ForeColor = ThemeColor.PrimaryColor;
        }

        private async void LoadDataTicket()
        {
            string response = await ApiHandler.client.GetStringAsync("import");
            rows = JsonConvert.DeserializeObject<List<Ticket>>(response);

            DataTable tickets = new DataTable("tickets");

            tickets.Columns.Add(new DataColumn("Staff Id"));
            tickets.Columns.Add(new DataColumn("Staff Name"));
            tickets.Columns.Add(new DataColumn("Role"));
            tickets.Columns.Add(new DataColumn("Total Amount"));
            tickets.Columns.Add(new DataColumn("Total Cost"));
            tickets.Columns.Add(new DataColumn("Date"));



            foreach (Ticket record in rows)
            {
                DataRow row;
                row = tickets.NewRow();
                row["Staff Id"] = record.Staff.Id;
                row["Staff Name"] = record.Staff.Name;
                row["Role"] = record.Staff.Role.Name;
                row["Total Amount"] = record.TotalAmount;
                row["Total Cost"] = record.TotalCost;
                row["Date"] = record.Date;

                tickets.Rows.Add(row);
            }

            dataGridViewTicket.DataSource = tickets;
            LoadProduct();
        }

        private void LoadDataDetail(int id)
        {
            Ticket tiket = rows.Find((c) => c.Id == id);
            DataTable tickets = new DataTable("tickets");
            tickets.Columns.Add(new DataColumn("Product Id"));
            tickets.Columns.Add(new DataColumn("Product Name"));
            tickets.Columns.Add(new DataColumn("Price"));
            tickets.Columns.Add(new DataColumn("Import Amount"));


            foreach (TicketDetails rec in tiket.Details)
            {
                DataRow row;
                row = tickets.NewRow();
                row["Product Id"] = rec.Product.Id;
                row["Product Name"] = rec.Product.Name;
                row["Price"] = rec.Product.Price;
                row["Import Amount"] = rec.Amount;

                tickets.Rows.Add(row);
            }


            dataGridViewDetail.DataSource = tickets;
        }

        private void dataGridViewTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewTicket.Rows[e.RowIndex];

                textTotalAmount.Text = row.Cells["Total Amount"].Value.ToString();
                textTotalCost.Text = row.Cells["Total Cost"].Value.ToString();
                dateDate.Text = row.Cells["Date"].Value.ToString();
                LoadDataDetail (Int32.Parse(row.Cells["Staff Id"].Value.ToString()));
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
        private void addProductToList(object sender, EventArgs e)
        {
            int productId = ((KeyValuePair<int, string>)cbProductName.SelectedItem).Key;
            string productName = ((KeyValuePair<int, string>)cbProductName.SelectedItem).Value;

            Product product = new Product()
            {
                Id = productId,
                Name = productName
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

        private void LoadListProduct(Product product)
        {
            Delete.Name = "button";
            Delete.HeaderText = "Button";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true; //dont forget this line
            Product.Name = product.Name;
            //ProductId.Name = product.Id.ToString();
            //ProductId.Name, 
            dataGridViewProduct.Rows.Add(Product.Name, Delete);
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //var row = e.RowIndex;
                //var column = 1;
                //var id = dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                //var name = dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString();

                //var itemToRemove = rows_product.SingleOrDefault(r => r.Id == Int32.Parse(id));
                //if (itemToRemove != null)
                //  rows_product.Remove(itemToRemove);
                //var listProduct = rows_product;
                dataGridViewProduct.Rows.RemoveAt(e.RowIndex);


            }
        }
        private bool checkExistProduct()
        {
            var flag = false;
            int productId = ((KeyValuePair<int, string>)cbProductName.SelectedItem).Key;
            for (int rows = 0; rows < dataGridViewProduct.Rows.Count - 1; rows++)
            {
                var Id = Int32.Parse(dataGridViewProduct.Rows[rows].Cells[0].Value.ToString());
                if (productId == Id)
                {
                    flag = true;
                }

            }
            return flag;
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            List<Product> rows_product = new List<Product>();
            var x = dataGridViewProduct.Rows.Count;
            for (int rows = 0; rows < dataGridViewProduct.Rows.Count - 1; rows++)
            {
                Product product = new Product()
                {
                    Id = Int32.Parse(dataGridViewProduct.Rows[rows].Cells[0].Value.ToString()),
                    Name = dataGridViewProduct.Rows[rows].Cells[1].Value.ToString(),
                    Amount = Int32.Parse(dataGridViewProduct.Rows[rows].Cells[2].Value.ToString())
                };
                rows_product.Add(product);
            }
            List<TicketDetails> listTicketDetails = new List<TicketDetails>();
            foreach (var item in rows_product)
            {
                TicketDetails ticketDetails = new TicketDetails()
                {
                    Product = new Product()
                    {
                        Id = item.Id
                    },
                    Amount = 10
                };

                listTicketDetails.Add(ticketDetails);
            }
            Ticket ticket = new Ticket()
            {
                Date = dateDate.Text,
                TotalAmount = Int32.Parse(textTotalAmount.Text),
                TotalCost = Double.Parse(textTotalCost.Text),
                Details = listTicketDetails
            };
            await ApiHandler.client.PostAsJsonAsync("Import", ticket);
            LoadDataTicket();
        }

    }



   
}
