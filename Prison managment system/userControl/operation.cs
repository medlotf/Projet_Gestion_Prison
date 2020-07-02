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
    public partial class operation : UserControl
    {

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HSKBO3M\SQLEXPRESS;Initial Catalog=PrisonMangment;Integrated Security=True;");
        SqlDataReader rd;
       
        SqlCommand cd;
        SqlDataAdapter da;
        DataTable Dt = new DataTable();
        DataSet ds= new DataSet();
        int id;
        public operation(int i)
        {
            id = i;
            InitializeComponent();
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label20.Text = "";
            label21.Text = "";

            cn.Open();




        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.Rows.Clear();
            bunifuCustomDataGrid2.Rows.Clear();

            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";

            string typ="pId";
           /* try
            {
                if (bunifuDropdown1.selectedValue == "CIN")
                    typ = "pCIN";
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Please select a value !!");
            }*/
            try
            { 
            cd = new SqlCommand("Select * From PRISONNIER where " + typ + "=" + bunifuMetroTextbox1.Text, cn);
            rd = cd.ExecuteReader();
            
            while(rd.Read())
            {
                
                label10.Text = Convert.ToString(rd[0]);
                label11.Text = Convert.ToString(rd[1])+" " + Convert.ToString(rd[2]);
                label12.Text = Convert.ToString(rd[3]);
                label13.Text = Convert.ToString(rd[4]);
                label14.Text = Convert.ToString(rd[8]);
                label15.Text = Convert.ToString(rd[5]);
                label16.Text = Convert.ToString(rd[6]);
                label17.Text = Convert.ToString(rd[7]);
            }

                rd.Close();
            }
            catch (SqlException ex)
            {
                bunifuCustomDataGrid1.Rows.Clear();
                MessageBox.Show("wrong Search Value !!");

            }

            rd.Close();
          

            string[] row;
            try
            {
                rd.Close();
                cd = new SqlCommand("select crType as Crime,crDesc ,dateEntre,dateExit from CRIME where pId="+ bunifuMetroTextbox1.Text, cn);
            rd = cd.ExecuteReader();
            while (rd.Read())
            {
                row = new String[] { Convert.ToString(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]),Convert.ToString(rd[3]) };
                bunifuCustomDataGrid1.Rows.Add(row);
            }

                rd.Close();
            }
            catch (SqlException ex)
            {
               
                MessageBox.Show("Error !!",ex.Message);

            }

            try
            {
                rd.Close();
                cd = new SqlCommand("select sbj,descript,rDate from REPORT where pId=" + bunifuMetroTextbox1.Text, cn);
                rd = cd.ExecuteReader();
                while (rd.Read())
                {
                    row = new String[] { Convert.ToString(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]) };
                    bunifuCustomDataGrid2.Rows.Add(row);
                }

                rd.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error !!", ex.Message);

            }
            /*
            string[] row;

            da = new SqlDataAdapter("select crType as Crime ,dateEntre,dateExit from CRIME_PRISONNIER cr,CRIME c where c.crId=cr.crId and pId=" + Convert.ToString(1), cn);
            da.Fill(ds,"b");
            
            bunifuCustomDataGrid1.DataSource = ds.Tables["b"];
*/
           



        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            try
            { 
            cd = new SqlCommand("insert into DEMAND(dType,descript,gId,Answer) values('"+ bunifuMetroTextbox5.Text+ "','" + bunifuCustomTextbox1.Text + "','"+Convert.ToString(id)+"','L')", cn);
            cd.ExecuteNonQuery();
                MessageBox.Show("Send Successfully !", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(SqlException ex)
            {
                MessageBox.Show("Some Errors occured" + ex.Message);
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            label20.Text = "";
            label21.Text = "";
            try
            {
                cd = new SqlCommand("Select * From PRISONNIER where pId =" + bunifuMetroTextbox2.Text, cn);
                rd = cd.ExecuteReader();

                while (rd.Read())
                {
              
                    label20.Text = Convert.ToString(rd[0]);
                    label21.Text = Convert.ToString(rd[1])+" "+ Convert.ToString(rd[2]);
                    
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Didnt found him !!");

            }
            rd.Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

            try
            {
                cd = new SqlCommand("insert into REPORT(sbj, descript, gId, pId) values('"+ bunifuMetroTextbox3.Text + "', '"+ bunifuCustomTextbox2.Text + "', "+ Convert.ToString(id) + ", "+ label20.Text + ")", cn);
                cd.ExecuteNonQuery();
                MessageBox.Show("Send Successfully !", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Some Errors occured" + ex.Message);
            }
            bunifuMetroTextbox2.Text = "";
            label20.Text = "";
            label21.Text = "";
            bunifuMetroTextbox3.Text = "";
            bunifuCustomTextbox2.Text = "";

        }
    }
}
