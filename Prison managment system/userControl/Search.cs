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
    public partial class Search : UserControl
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HSKBO3M\SQLEXPRESS;Initial Catalog=PrisonMangment;Integrated Security=True;");
        SqlDataReader rd;
        SqlCommand cd;
     
        public Search()
        {
            InitializeComponent();
           
            cn.Open();
            }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            label10.Text = "";
            label11.Text ="";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label28.Text = "";
            label30.Text = "";
            try
            {
                if (comboBox1.Text == "ID")
                {
                    cd = new SqlCommand("SELECT [pId] ,[fName],[lName],[Age],[Gender],[pHeight],[pWeight],[Adresse],[pCIN],p.[cId],bId FROM PRISONNIER p ,CELL c where p.cId=c.cId and pId ='" + bunifuMetroTextbox1.Text + "'", cn);

                }

                else if (comboBox1.Text == "CIN")
                {
                    cd = new SqlCommand("SELECT [pId] ,[fName],[lName],[Age],[Gender],[pHeight],[pWeight],[Adresse],[pCIN],p.[cId],bId FROM PRISONNIER p ,CELL c where p.cId=c.cId and pCIN ='" + bunifuMetroTextbox1.Text + "'", cn);

                }
                else
                {
                    MessageBox.Show("Select a value");
                    return;
                }
                rd = cd.ExecuteReader();

                while (rd.Read())
                {

                    label10.Text = Convert.ToString(rd[0]);
                    label11.Text = Convert.ToString(rd[1]) + " " + Convert.ToString(rd[2]);
                    label12.Text = Convert.ToString(rd[3]);
                    label13.Text = Convert.ToString(rd[4]);
                    label14.Text = Convert.ToString(rd[8]);
                    label15.Text = Convert.ToString(rd[5]);
                    label16.Text = Convert.ToString(rd[6]);
                    label17.Text = Convert.ToString(rd[7]);
                    label28.Text= Convert.ToString(rd[9]);
                    label30.Text = Convert.ToString(rd[10]);
                }

                rd.Close();
            }
            catch (SqlException ex)
            {
                bunifuCustomDataGrid1.Rows.Clear();
                MessageBox.Show("wrong Search Value !!", ex.Message);

            }

            bunifuCustomDataGrid1.Rows.Clear();



            
            string[] row;
            try
            {
                if (comboBox1.Text == "ID")
                {
                    cd = new SqlCommand("SELECT  crId, crType,dateEntre,dateExit from CRIME where pId =" + bunifuMetroTextbox1.Text, cn);

                }

                else if (comboBox1.Text == "CIN")
                {
                    cd = new SqlCommand("SELECT  crId, crType,dateEntre,dateExit from CRIME c,PRISONNIER p where p.pId =c.pId and p.pCIN='" + bunifuMetroTextbox1.Text + "'", cn);

                }
                else
                {
                    MessageBox.Show("Select a value");
                    return;
                }
                rd = cd.ExecuteReader();
                while (rd.Read())
                {
                    row = new String[] { Convert.ToString(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]) };
                    bunifuCustomDataGrid1.Rows.Add(row);
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {


            bunifuCustomDataGrid2.Rows.Clear();
            //MessageBox.Show(comboBox33.Text);
            string[] row;
                try
            {

                if (comboBox33.Text == "Gardes")
                {
                    cd = new SqlCommand("SELECT  gId,fName,lName,gCIN FROM GARDE  ", cn);
                }

                else if (comboBox33.Text == "Prisoners")
                {
                    cd = new SqlCommand("SELECT  pId,fName,lName,pCIN from PRISONNIER ", cn);
                }

                else
                {
                    MessageBox.Show("Select a value");
                return;
 }
                rd = cd.ExecuteReader();
                
                while (rd.Read())
                {
                    
                    row = new String[] { Convert.ToString(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]), Convert.ToString(rd[3]) };
                   /* foreach (string strr in row)
                    {
                        MessageBox.Show(strr);
                    }*/
                    bunifuCustomDataGrid2.Rows.Add(row);
                }
               
                rd.Close();
            }
            catch (SqlException ex)
            {
                bunifuCustomDataGrid1.Rows.Clear();
                MessageBox.Show("Error !!", ex.Message);

            }
           

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            label22.Text ="";
            label21.Text = "";
            label20.Text = "";
            label3.Text = "";
            label29.Text ="";
            label32.Text = "";
            label34.Text = "";


            try
            {

                if (comboBox2.Text == "ID")
                {
                   
                    cd = new SqlCommand("SELECT [gId] ,[fName],[lName],[Age],[Gender],[Adresse],[gCIN],bId from GARDE where gId='" + bunifuMetroTextbox2.Text + "'", cn);

                }

                else if (comboBox2.Text == "CIN")
                {
                   
                    cd = new SqlCommand("SELECT [gId] ,[fName],[lName],[Age],[Gender],[Adresse],[gCIN],bId from GARDE where gCIN='" + bunifuMetroTextbox2.Text + "'", cn);

                }
                else
                {
                    
                    MessageBox.Show("Select a value");
                    return;
                }
                rd = cd.ExecuteReader();
                
                while (rd.Read())
                {
                    
                    label22.Text = Convert.ToString(rd[0]);
                    label21.Text = Convert.ToString(rd[1]) + " " + Convert.ToString(rd[2]);
                    label20.Text = Convert.ToString(rd[3]);
                    label3.Text = Convert.ToString(rd[4]);
                    label29.Text = Convert.ToString(rd[5]);
                    label32.Text = Convert.ToString(rd[6]);
                    label34.Text = Convert.ToString(rd[7]);

                }

                rd.Close();
            }
            catch (SqlException ex)
            {
                bunifuCustomDataGrid1.Rows.Clear();
                MessageBox.Show("wrong Search Value !!", ex.Message);

            }
   
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid3.Rows.Clear();
            string[] row;
            try
            {
                cd = new SqlCommand("SELECT [dId] ,[dType] ,[descript],[sendDate],[gId],[Answer] FROM [PrisonMangment].[dbo].[DEMAND] where gId='" + bunifuMetroTextbox3.Text + "'", cn);
                rd = cd.ExecuteReader();
                while (rd.Read())
                {
                    row = new String[] { Convert.ToString(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]), Convert.ToString(rd[3]), Convert.ToString(rd[4]), Convert.ToString(rd[5])};
                    bunifuCustomDataGrid3.Rows.Add(row);
                }

                rd.Close();
            }
            catch (SqlException ex)
            {
                bunifuCustomDataGrid3.Rows.Clear();
                MessageBox.Show("Error !!", ex.Message);

            }
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            bunifuCustomDataGrid3.Rows.Clear();
            string[] row;
            try
            {
                cd = new SqlCommand("SELECT [dId] ,[dType] ,[descript],[sendDate],[gId],[Answer] FROM [PrisonMangment].[dbo].[DEMAND] ", cn);
                rd = cd.ExecuteReader();
                while (rd.Read())
                {
                    row = new String[] { Convert.ToString(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]), Convert.ToString(rd[3]), Convert.ToString(rd[4]), Convert.ToString(rd[5]) };
                    bunifuCustomDataGrid3.Rows.Add(row);
                }

                rd.Close();
            }
            catch (SqlException ex)
            {
                bunifuCustomDataGrid3.Rows.Clear();
                MessageBox.Show("Error !!", ex.Message);

            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid4.Rows.Clear();
            string[] row;
            try
            {
                cd = new SqlCommand("SELECT [rID],[pId],[sbj],[descript],[rDate],[gId] FROM [PrisonMangment].[dbo].[REPORT] where pId='" + bunifuMetroTextbox4.Text + "'", cn);
                rd = cd.ExecuteReader();
                while (rd.Read())
                {
                    row = new String[] { Convert.ToString(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]), Convert.ToString(rd[3]) ,Convert.ToString(rd[4]),Convert.ToString(rd[5])  };
                    bunifuCustomDataGrid4.Rows.Add(row);
                }

                rd.Close();
            }
            catch (SqlException ex)
            {
                bunifuCustomDataGrid4.Rows.Clear();
                MessageBox.Show("Error !!", ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid4.Rows.Clear();
            string[] row;
            try
            {
                cd = new SqlCommand("SELECT [rID],[pId],[sbj],[descript],[rDate],[gId] FROM [PrisonMangment].[dbo].[REPORT]", cn);
                rd = cd.ExecuteReader();
                while (rd.Read())
                {
                    row = new String[] { Convert.ToString(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]), Convert.ToString(rd[3]), Convert.ToString(rd[4]), Convert.ToString(rd[5]) };
                    bunifuCustomDataGrid4.Rows.Add(row);
                }

                rd.Close();
            }
            catch (SqlException ex)
            {
                bunifuCustomDataGrid4.Rows.Clear();
                MessageBox.Show("Error !!", ex.Message);

            }
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid5.Rows.Clear();
            string[] row;
            try
            {
                cd = new SqlCommand("SELECT  pId,[actvType] ,[descript],DATEDIFF(day, dateBeg, dateEnd) AS   duration FROM ACTIVITY a ,ACTIVITY_PRISONNIER p where p.aId=a.aId and p.pId='" + bunifuMetroTextbox6.Text + "'", cn);
                rd = cd.ExecuteReader();
                while (rd.Read())
                {
                    row = new String[] { Convert.ToString(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]), Convert.ToString(rd[3]) };
                    bunifuCustomDataGrid5.Rows.Add(row);
                }

                rd.Close();
            }
            catch (SqlException ex)
            {
                bunifuCustomDataGrid5.Rows.Clear();
                MessageBox.Show("Error !!", ex.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid5.Rows.Clear();
            string[] row;
            try
            {
                cd = new SqlCommand("SELECT  pId,[actvType] ,[descript],DATEDIFF(day, dateBeg, dateEnd) AS   duration FROM ACTIVITY a ,ACTIVITY_PRISONNIER p where p.aId=a.aId;", cn);
                rd = cd.ExecuteReader();
                while (rd.Read())
                {
                    row = new String[] { Convert.ToString(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]), Convert.ToString(rd[3]) };
                    bunifuCustomDataGrid5.Rows.Add(row);
                }

                rd.Close();
            }
            catch (SqlException ex)
            {
                bunifuCustomDataGrid5.Rows.Clear();
                MessageBox.Show("Error !!", ex.Message);

            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid5.Rows.Clear();
            string[] row;
            try
            {
                cd = new SqlCommand("SELECT  [aId],[actvType] ,[descript] FROM [PrisonMangment].[dbo].[ACTIVITY]", cn);
                rd = cd.ExecuteReader();
                while (rd.Read())
                {
                    row = new String[] { Convert.ToString(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]) };
                    bunifuCustomDataGrid5.Rows.Add(row);
                }

                rd.Close();
            }
            catch (SqlException ex)
            {
                bunifuCustomDataGrid5.Rows.Clear();
                MessageBox.Show("Error !!", ex.Message);

            }
        }
    }
}

