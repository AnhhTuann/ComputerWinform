using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
