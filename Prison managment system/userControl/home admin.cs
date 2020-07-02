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
    public partial class home_admin : UserControl
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HSKBO3M\SQLEXPRESS;Initial Catalog=PrisonMangment;Integrated Security=True;");
        SqlDataReader rd;
        SqlCommand cd;
        public home_admin()
        {
            InitializeComponent();

           
            cd = new SqlCommand("Select * From GARDE where gId= " + Convert.ToString(LogInForm.ID), cn);
            cn.Open();
            rd = cd.ExecuteReader();
            while (rd.Read())
            {
                label3.Text = Convert.ToString(rd[1]) + " " + Convert.ToString(rd[2]);
                

            }
        }
    }
}
