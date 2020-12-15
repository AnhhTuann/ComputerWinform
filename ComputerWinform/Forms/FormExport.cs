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
    public partial class FormExport : Form
    {
        private List<Export> rows = new List<Export>();
        public FormExport()
        {
            InitializeComponent();
        }

        private void FormExport_Load(object sender, EventArgs e)
        {
            LoadDataExport();
        }

        private async void LoadDataExport()
        {
            string response = await ApiHandler.client.GetStringAsync("export");
            rows = JsonConvert.DeserializeObject<List<Export>>(response);

            DataTable tickets = new DataTable("exports");

            tickets.Columns.Add(new DataColumn("Staff Id"));
            tickets.Columns.Add(new DataColumn("Staff Name"));
            tickets.Columns.Add(new DataColumn("Role"));
            tickets.Columns.Add(new DataColumn("Date"));



            foreach (Export record in rows)
            {
                DataRow row;
                row = tickets.NewRow();
                row["Staff Id"] = record.Staff.Id;
                row["Staff Name"] = record.Staff.Name;
                row["Role"] = record.Staff.Role.Name;
                row["Date"] = record.Date;

                tickets.Rows.Add(row);
            }

            dataGridViewTicket.DataSource = tickets;
            LoadDataReceipt();
        }
        private void LoadDataDetail(int id)
        {
            Export tiket = rows.Find((c) => c.Id == id);
            DataTable tickets = new DataTable("exports");
            tickets.Columns.Add(new DataColumn("Product Id"));
            tickets.Columns.Add(new DataColumn("Product Name"));
            tickets.Columns.Add(new DataColumn("Price"));


            foreach (TicketDetails rec in tiket.Details)
            {
                DataRow row;
                row = tickets.NewRow();
                row["Product Id"] = rec.Product.Id;
                row["Product Name"] = rec.Product.Name;
                row["Price"] = rec.Product.Price;

                tickets.Rows.Add(row);
            }


            dataGridViewDetail.DataSource = tickets;
        }
        private async void LoadDataReceipt()
        {
            string response = await ApiHandler.client.GetStringAsync("export");
            rows = JsonConvert.DeserializeObject<List<Export>>(response);

            DataTable tickets = new DataTable("exports");

            tickets.Columns.Add(new DataColumn("Customer Name"));
            tickets.Columns.Add(new DataColumn("Recipient"));
            tickets.Columns.Add(new DataColumn("Address"));
            tickets.Columns.Add(new DataColumn("Phone"));
            tickets.Columns.Add(new DataColumn("Date"));
            tickets.Columns.Add(new DataColumn("Total Cost"));



            foreach (Export record in rows)
            {
                DataRow row;
                row = tickets.NewRow();
                row["Customer Name"] = record.Receipt.Customer;
                row["Recipient"] = record.Receipt.Recipient;
                row["Address"] = record.Receipt.Address;
                row["Phone"] = record.Receipt.Phone;
                row["Date"] = record.Receipt.Date;
                row["Total Cost"] = record.Receipt.TotalCost;

                tickets.Rows.Add(row);
            }

            dataGridViewReceipt.DataSource = tickets;
        }



        private void dataGridViewTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewTicket.Rows[e.RowIndex];
                LoadDataDetail(Int32.Parse(row.Cells["Staff Id"].Value.ToString()));
            }
        }
    }
}
