using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerWinform.Forms;

namespace ComputerWinform.Forms
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;
            if(panel2.Width >= 800)
            {
                timer1.Stop();
                FormMainMenu mainMenu = new FormMainMenu();
                mainMenu.Show();
                this.Hide();
            }
        }
    }
}
