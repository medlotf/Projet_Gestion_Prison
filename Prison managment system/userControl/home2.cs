using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prison_managment_system.userControl
{
    public partial class home2 : UserControl
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HSKBO3M\SQLEXPRESS;Initial Catalog=PrisonMangment;Integrated Security=True;");
        SqlDataReader rd;
        SqlCommand cd;

        public home2()
        {
           
        }
        public home2(int id)
        {
            InitializeComponent();
            cd = new SqlCommand("Select * From GARDE where gId= " + Convert.ToString(id), cn);
            cn.Open();
            rd = cd.ExecuteReader();
            while (rd.Read())
            {
                label3.Text = Convert.ToString(rd[1]) + " " + Convert.ToString(rd[2]);
                label5.Text = Convert.ToString(rd[6]);
                //MessageBox.Show(Convert.ToString(rd[3]) + "+" + Convert.ToString(rd[4]) + "+" + Convert.ToString(rd[5]) + "+" + Convert.ToString(rd[6]));

            }
        }

        private void home2_Load(object sender, EventArgs e)
        {

        }
    }
}
