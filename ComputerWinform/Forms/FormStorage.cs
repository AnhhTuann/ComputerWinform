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
            LoadProduct();
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
            string response = await ApiHandler.client.GetStringAsync("ticket");
            rows = JsonConvert.DeserializeObject<List<Ticket>>(response);

            DataTable tickets = new DataTable("tickets");

            tickets.Columns.Add(new DataColumn("Staff Id"));
            tickets.Columns.Add(new DataColumn("Staff Name"));
            tickets.Columns.Add(new DataColumn("Role"));
            tickets.Columns.Add(new DataColumn("Total Amount"));
            tickets.Columns.Add(new DataColumn("Total Cost"));
            tickets.Columns.Add(new DataColumn("Import/Export"));
            tickets.Columns.Add(new DataColumn("Date"));



            foreach (Ticket record in rows)
            {
                DataRow row;
                row = tickets.NewRow();
                row["Staff Id"] = record.Staff.Id;
                row["Staff Name"] = record.Staff.Name;
                row["Role"] = record.Staff.Role;
                row["Total Amount"] = record.TotalAmount;
                row["Total Cost"] = record.TotalCost;
                row["Import/Export"] = record.IsImport;
                row["Date"] = record.Date;

                tickets.Rows.Add(row);
            }

            //dataGridViewTicket.DataSource = tickets;
            //LoadProduct();
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


            //dataGridViewDetail.DataSource = tickets;
        }

        private void dataGridViewTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //DataGridViewRow row = this.dataGridViewTicket.Rows[e.RowIndex];

                //textTotalAmount.Text = row.Cells["Total Amount"].Value.ToString();
                //textTotalCost.Text = row.Cells["Total Cost"].Value.ToString();
                //textIsImport.Text = row.Cells["Import/Export"].Value.ToString();
                //dateDate.Text = row.Cells["Date"].Value.ToString();
                LoadDataDetail (Int32.Parse(row.Cells["Staff Id"].Value.ToString()));
            }
        }
        
        private async void LoadData()
        {
            string response = await ApiHandler.client.GetStringAsync("storage");
            List<Storage> rows = JsonConvert.DeserializeObject<List<Storage>>(response);
            DataTable storages = new DataTable("storage");

            storages.Columns.Add(new DataColumn("Id"));
            storages.Columns.Add(new DataColumn("ProductId"));
            storages.Columns.Add(new DataColumn("ProductName"));
            storages.Columns.Add(new DataColumn("Import"));
            storages.Columns.Add(new DataColumn("Export"));
            storages.Columns.Add(new DataColumn("Date"));

            foreach (Storage record in rows)
            {
                DataRow row;
                row = storages.NewRow();
                row["Id"] = record.Id;
                row["ProductId"] = record.Product.Id;
                row["ProductName"] = record.Product.Name;
                row["Import"] = record.Import;
                row["Export"] = record.Export;
                row["Date"] = record.Date;

                storages.Rows.Add(row);
            }

            dataGridViewStorage.DataSource = storages;
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

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if(checkValueForm())
            {
                Storage storage = new Storage();
                storage.Product = new Product()
                {
                    Id = Int32.Parse(cbProductName.Text),
                };
                storage.Import = Int32.Parse(textImport.Text);
                storage.Export = Int32.Parse(textExport.Text);
                storage.Date = DateTime.Parse(dateTimePicker1.Text);
                //textImport
                var response = await ApiHandler.client.PostAsJsonAsync("storage", storage);
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (checkValueForm())
            {

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }
        private bool checkValueForm()
        {
            string message = "";
            string title = "Error";

            if (cbProductName.Text == "")
            {
                message = "Please input product name";
                MessageBox.Show(message, title);
                cbProductName.Focus();
                return false;
            }
            if (textImport.Text == "")
            {
                message = "Please input product description";
                MessageBox.Show(message, title);
                textImport.Focus();
                return false;
            }
            if (textExport.Text == "")
            {
                message = "Please input product price";
                MessageBox.Show(message, title);
                textExport.Focus();
                return false;
            }

            return true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewStorage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewStorage.Rows[e.RowIndex];

                textStorageId.Text = row.Cells["Id"].Value.ToString();
                cbProductName.Text = row.Cells["ProductId"].Value.ToString();
                textImport.Text = row.Cells["Import"].Value.ToString();
                textExport.Text = row.Cells["Export"].Value.ToString();
                dateTimePicker1.Text = row.Cells["Date"].Value.ToString();

            }
        }
    }



   
}
