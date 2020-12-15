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
        private Export export = new Export();
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
            tickets.Columns.Add(new DataColumn("Id"));
            tickets.Columns.Add(new DataColumn("Staff Id"));
            tickets.Columns.Add(new DataColumn("Staff Name"));
            tickets.Columns.Add(new DataColumn("Role"));
            tickets.Columns.Add(new DataColumn("Date"));



            foreach (Export record in rows)
            {
                DataRow row;
                row = tickets.NewRow();
                row["Id"] = record.Id;
                row["Staff Id"] = record.Staff.Id;
                row["Staff Name"] = record.Staff.Name;
                row["Role"] = record.Staff.Role.Name;
                row["Date"] = record.Date;

                tickets.Rows.Add(row);
            }

            dataGridViewTicket.DataSource = tickets;
            LoadDataReceipt();
        }
        private async void LoadListProductAndCombo(int id)
        {
            string response = await ApiHandler.client.GetStringAsync("export/" + id);
            export = JsonConvert.DeserializeObject<Export>(response);

            DataTable products = new DataTable("products");

            products.Columns.Add(new DataColumn("Product Id"));
            products.Columns.Add(new DataColumn("Product Name"));
            products.Columns.Add(new DataColumn("Price"));
            products.Columns.Add(new DataColumn("Amount"));



            foreach (ReceiptDetails record in export.Receipt.Details)
            {
                DataRow row;
                row = products.NewRow();
                row["Product Id"] = record.Product.Id;
                row["Product Name"] = record.Product.Name;
                row["Price"] = record.Product.Price;
                row["Amount"] = record.Amount;

                products.Rows.Add(row);
            }
            DataTable combos = new DataTable("combos");

            combos.Columns.Add(new DataColumn("Combo Id"));
            combos.Columns.Add(new DataColumn("Combo Name"));
            combos.Columns.Add(new DataColumn("Price"));
            combos.Columns.Add(new DataColumn("Amount"));



            foreach (ReceiptCombos record in export.Receipt.Combos)
            {
                DataRow row;
                row = combos.NewRow();
                row["Combo Id"] = record.Combo.Id;
                row["Combo Name"] = record.Combo.Name;
                row["Price"] = record.Combo.Price;
                row["Amount"] = record.Amount;

                combos.Rows.Add(row);
            }


            dataGridView1.DataSource = combos;

            dataGridViewDetail.DataSource = products;


        }
        private async void LoadListCombo(int id)
        {
            string response = await ApiHandler.client.GetStringAsync("export/" + id);
            export = JsonConvert.DeserializeObject<Export>(response);

            DataTable combos = new DataTable("combos");

            combos.Columns.Add(new DataColumn("Combo Id"));
            combos.Columns.Add(new DataColumn("Combo Name"));
            combos.Columns.Add(new DataColumn("Price"));
            combos.Columns.Add(new DataColumn("Amount"));



            foreach (ReceiptCombos record in export.Receipt.Combos)
            {
                DataRow row;
                row = combos.NewRow();
                row["Combo Id"] = record.Combo.Id;
                row["Combo Name"] = record.Combo.Name;
                row["Price"] = record.Combo.Price;
                row["Amount"] = record.Amount;

                combos.Rows.Add(row);
            }


            dataGridView1.DataSource = combos;
        }


        private async void LoadDataReceipt()
        {
            string response = await ApiHandler.client.GetStringAsync("export");
            rows = JsonConvert.DeserializeObject<List<Export>>(response);

            DataTable tickets = new DataTable("exports");
            tickets.Columns.Add(new DataColumn("Id"));
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
                row["Id"] = record.Id;
                row["Customer Name"] = record.Receipt.Customer.Name;
                row["Recipient"] = record.Receipt.Recipient;
                row["Address"] = record.Receipt.Address;
                row["Phone"] = record.Receipt.Phone;
                row["Date"] = record.Receipt.Date;
                row["Total Cost"] = record.Receipt.TotalCost;

                tickets.Rows.Add(row);
            }


            dataGridViewReceipt.DataSource = tickets;
        }

        private void dataGridViewReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewReceipt.Rows[e.RowIndex];
                LoadListProductAndCombo(Int32.Parse(row.Cells["Id"].Value.ToString()));
            }
        }
    }
}
