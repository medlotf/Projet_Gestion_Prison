using System;
using System.Windows.Forms;

namespace Prison_managment_system
{
    public partial class Main_Page : Form
    {
       
        public Main_Page()
        {
            InitializeComponent();
            panel1.Top = button1.Top;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Top = button1.Top;
           home21.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Top = button2.Top;
            profile22.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Top = button3.Top;
            operation1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Top = button4.Top; this.Close();
            LogInForm f1 = new LogInForm();
            f1.Show();
            
            
        }
        
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {
            home21.BringToFront();
        }

        private void home1_Load(object sender, EventArgs e)
        {
            
        }

        private void sideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home21_Load(object sender, EventArgs e)
        {
            
        }

        private void profile22_Load(object sender, EventArgs e)
        {

        }
    }
}
