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
    public partial class FormStorageImport : Form
    {
        private List<Ticket> rows = new List<Ticket>();
        public FormStorageImport()
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
            tickets.Columns.Add(new DataColumn("Import"));  
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
                textIsImport.Text = row.Cells["Import"].Value.ToString();
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
    }



   
}
