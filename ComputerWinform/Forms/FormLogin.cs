using DTO;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panelRes.Visible = false;
            guna2Transition1.HideSync(panelRes);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panelRes.Visible = true;
            guna2Transition1.ShowSync(panelRes);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            LoadingForm loading = new LoadingForm();
            loading.Show();
            this.Hide();
        }

        private async void createAccount(object sender, EventArgs e)
        {
            
            Person customer = new Person()
            {
                Name = TextName.Text,
                Email = textEmail.Text,
                Password = textPassword.Text,
                Address = textAddress.Text,
                Phone = textPhone.Text,
            };

             await ApiHandler.client.PostAsJsonAsync("customer", customer);
        }
        private async void login(object sender, EventArgs e)
        {
            Staff staff = new Staff()
            {
                Email = textEmail.Text,
                Password = textPassword.Text,
            };
            var response = await ApiHandler.client.PostAsJsonAsync("login", staff);
            Console.WriteLine(response);
        }
    }
}
