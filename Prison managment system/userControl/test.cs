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
    public partial class test : UserControl
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HSKBO3M\SQLEXPRESS;Initial Catalog=PrisonMangment;Integrated Security=True;");
        SqlDataReader rd;
        SqlCommand cd;

        DataTable Dt = new DataTable();
        public test(int id)
        {
            InitializeComponent();
            cn.Open();
            string[] row;

            try
            {
                /*Da = new SqlDataAdapter("Select dType as Type ,descript as Description,sendDate as Date ,Answer as Respond From DEMAND ", cn);*/
                /*Da.Fill(Dt);
                 bunifuCustomDataGrid1.DataSource=Dt;*/
                cd = new SqlCommand("Select dType as Type ,descript as Description,sendDate as Date ,Answer as Respond From DEMAND where gId=" + Convert.ToString(id), cn);
                rd = cd.ExecuteReader();
                while (rd.Read())
                {
                    row = new String[] { Convert.ToString(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]), Convert.ToString(rd[3]) };
                    bunifuCustomDataGrid1.Rows.Add(row);
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Error : " + e);
            }

            rd.Close();
            cd = new SqlCommand("Select * From GARDE where gId=" + Convert.ToString(id), cn);
            rd = cd.ExecuteReader();
            while (rd.Read())
            {
                label7.Text = Convert.ToString(rd[0]);
                label8.Text = Convert.ToString(rd[1]) + " " + Convert.ToString(rd[2]);
                label10.Text = Convert.ToString(rd[3]);
                label9.Text = Convert.ToString(rd[4]);
                label11.Text = Convert.ToString(rd[5]);
                label13.Text = Convert.ToString(rd[6]);
            }
        }
    }
}
