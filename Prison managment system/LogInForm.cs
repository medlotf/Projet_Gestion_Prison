using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prison_managment_system
{
   
    public partial class LogInForm : Form
    {
        public static int ID;
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HSKBO3M;Initial Catalog=PrisonMangment;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public LogInForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
              
                cn.Open();
                cmd = new SqlCommand(" select id ,COUNT(lid) as num from prisonLOGIN where lId='" + idtext.Text + "' and mdp='" + mdptext.Text + "'and LgType='g' group by id", cn);
                dr = cmd.ExecuteReader();
            // MessageBox.Show(Convert.ToString(dr.Read()));

            if (dr.Read())
            {
               


                if (dr[1].ToString() == "1")
                {
                    ID = Convert.ToInt32(dr[0].ToString());
                    //MessageBox.Show("2");
                    this.Hide();
                    Main_Page p1 = new Main_Page();
                    p1.Show();
                    return;
                    
                }
            }
            dr.Close();
            cmd = new SqlCommand(" select id ,COUNT(lid) as num from prisonLOGIN where lId='" + idtext.Text + "' and mdp='" + mdptext.Text + "'and LgType='a' group by id", cn);
            dr = cmd.ExecuteReader();
                if (dr.Read())
            {

                //MessageBox.Show("3");
                if (dr[1].ToString() == "1")
                {
                    ID = Convert.ToInt32(dr[0].ToString());
                    // MessageBox.Show("4");
                    this.Hide();
                            Main_page_Admin p2 = new Main_page_Admin();
                            p2.Show();
                            return;
                        }dr.Close();

                    }
            else
                    MessageBox.Show("Invalide ID or Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cn.Close();
            }
       

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
