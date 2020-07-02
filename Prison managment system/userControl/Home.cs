using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Prison_managment_system.userControl
{
    public partial class home : UserControl
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HSKBO3M\SQLEXPRESS;Initial Catalog=PrisonMangment;Integrated Security=True;");
        SqlDataReader rd;
        SqlCommand cd;
        DataTable Dt = new DataTable();
        public home(int id)
        {
            InitializeComponent();
            cd = new SqlCommand("Select * From GARDE where gId=" + Convert.ToString(6), cn);
            cn.Open();
            rd = cd.ExecuteReader();
            while (rd.Read())
            {
                label3.Text = Convert.ToString(rd[1])+" "+Convert.ToString(rd[2])  ;
                label5.Text = Convert.ToString(rd[6]);


            }

        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
