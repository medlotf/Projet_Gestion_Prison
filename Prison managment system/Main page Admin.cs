using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prison_managment_system
{
    public partial class Main_page_Admin : Form
    {
        public Main_page_Admin()
        {
            InitializeComponent();
            
    }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void operation_admin1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Top = button1.Top;
            home_admin1.BringToFront();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Top = button2.Top;
            search1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Top = button3.Top;
            operation_admin1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Top = button4.Top;
            this.Close();
            LogInForm f1 = new LogInForm();
            f1.Show();


        }

        private void Main_page_Admin_Load(object sender, EventArgs e)
        {
            panel1.Top = button1.Top;
            home_admin1.BringToFront();
        }
    }
}
