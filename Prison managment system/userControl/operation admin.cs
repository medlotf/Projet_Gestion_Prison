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
    public partial class operation_admin : UserControl
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HSKBO3M\SQLEXPRESS;Initial Catalog=PrisonMangment;Integrated Security=True;");
        SqlDataReader rd;
        SqlCommand cd;

        public operation_admin()
        {
            cn.Open();
            InitializeComponent();
            load();
            load2();
        }
            
        private void load()
        {
            bunifuCustomDataGrid3.Rows.Clear();
            comboBox1.Items.Clear();
            string[] row;
            try
            {
                cd = new SqlCommand("SELECT [dId] ,[dType] ,[descript],[sendDate],[gId],[Answer] FROM [PrisonMangment].[dbo].[DEMAND] where Answer='L'", cn);
                rd = cd.ExecuteReader();
                while (rd.Read())
                {
                    row = new String[] { Convert.ToString(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]), Convert.ToString(rd[3]), Convert.ToString(rd[4]), Convert.ToString(rd[5]) };
                    bunifuCustomDataGrid3.Rows.Add(row);
                    comboBox1.Items.Add(Convert.ToString(rd[0]));
                }

                rd.Close();
            }
            catch (SqlException ex)
            {
                bunifuCustomDataGrid3.Rows.Clear();
                MessageBox.Show("Error !!", ex.Message);

            }
        }
        private void load2()
        {
            bunifuCustomDataGrid3.Rows.Clear();
           
            try
            {
                cd = new SqlCommand("select * from CELL where nbrP<2", cn);
                rd = cd.ExecuteReader();
                while (rd.Read())
                {
                    comboBox5.Items.Add(Convert.ToString(rd[0]));
                }

                rd.Close();
            }
            catch (SqlException ex)
            {
                bunifuCustomDataGrid3.Rows.Clear();
                MessageBox.Show("Error !!", ex.Message);

            }
        }
            private void load3()
            {
            bunifuCustomDataGrid1.Rows.Clear();

            string[] row;
            try
            {
                rd.Close();
                cd = new SqlCommand("select crType as Crime,crDesc ,dateEntre,dateExit from CRIME where pId=" + label3.Text, cn);
                rd = cd.ExecuteReader();
                while (rd.Read())
                {
                    row = new String[] { Convert.ToString(rd[0]), Convert.ToString(rd[1]), Convert.ToString(rd[2]), Convert.ToString(rd[3]) };
                    bunifuCustomDataGrid1.Rows.Add(row);
                }

                rd.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error !!", ex.Message);

            }
        }
            private void operation_admin_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }
        private void clearG()
        {
            bunifuMetroTextbox2.Text = "";
            
            bunifuMetroTextbox5.Text = "";
            bunifuMetroTextbox6.Text = "";
            bunifuMetroTextbox7.Text = "";
            bunifuMetroTextbox8.Text = "";
            bunifuMetroTextbox9.Text = "";
            bunifuMetroTextbox10.Text = "";
            comboBox3.Text = "";
            label13.Text = "";
        }
        private void clearP()
        {
            bunifuMetroTextbox11.Text = "";
            bunifuMetroTextbox14.Text = "";
            bunifuMetroTextbox15.Text = "";
            bunifuMetroTextbox12.Text = "";
            bunifuMetroTextbox16.Text = "";
            bunifuMetroTextbox13.Text = "";
            bunifuMetroTextbox17.Text = "";
            bunifuMetroTextbox1.Text = "";
            bunifuMetroTextbox18.Text = "";
            comboBox5.Text = "";

           comboBox2.Text = "";
            label13.Text = "";
            label3.Text = "";
            comboBox5.Items.Clear();
            bunifuCustomDataGrid1.Rows.Clear();
        }
        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            clearG();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            

           
            try
            {

                if (comboBox3.Text == "ID")
                {

                    cd = new SqlCommand("SELECT gId,[fName],[lName],[Age],[Gender],[Adresse],[gCIN] from GARDE where gId='" + bunifuMetroTextbox2.Text + "'", cn);

                }

                else if (comboBox3.Text == "CIN")
                {

                    cd = new SqlCommand("SELECT gId,[fName],[lName],[Age],[Gender],[Adresse],[gCIN] from GARDE where gCIN='" + bunifuMetroTextbox2.Text + "'", cn);

                }
                else
                {

                    MessageBox.Show("Select a value");
                    return;
                }
                rd = cd.ExecuteReader();

                while (rd.Read())
                {
                    label13.Text=Convert.ToString(rd[0]);
                    bunifuMetroTextbox6.Text = Convert.ToString(rd[1]);
                    bunifuMetroTextbox5.Text = Convert.ToString(rd[2]);
                    bunifuMetroTextbox7.Text = Convert.ToString(rd[3]);
                    bunifuMetroTextbox9.Text = Convert.ToString(rd[4]);
                    bunifuMetroTextbox10.Text = Convert.ToString(rd[5]);
                    bunifuMetroTextbox8.Text = Convert.ToString(rd[6]);
                }

                rd.Close();
            }
            catch (SqlException ex)
            {
                bunifuCustomDataGrid1.Rows.Clear();
                MessageBox.Show("wrong Search Value !!", ex.Message);

            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult result = MessageBox.Show("do you want to delete this !", "warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    cd = new SqlCommand("delete from GARDE where gId='" + label13.Text + "'", cn);
                    cd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully !", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearG();
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Some Errors occured" + ex.Message);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("do you want to Update this !", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    cd = new SqlCommand("UPDATE GARDE SET fName ='" + bunifuMetroTextbox6.Text + "',lName= '" + bunifuMetroTextbox5.Text + "',Age='" + bunifuMetroTextbox7.Text + "',Gender='" + bunifuMetroTextbox9.Text + "',Adresse='" + bunifuMetroTextbox10.Text + "',gCIN='" + bunifuMetroTextbox8.Text + "' WHERE gId='" + label13.Text + "'", cn);
                    cd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully !", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearG();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Some Errors occured" + ex.Message);
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("do you want to insert this !", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if ((string.IsNullOrWhiteSpace(bunifuMetroTextbox6.Text)) || (string.IsNullOrWhiteSpace(bunifuMetroTextbox7.Text)) || (string.IsNullOrWhiteSpace(bunifuMetroTextbox5.Text)) || (string.IsNullOrWhiteSpace(bunifuMetroTextbox9.Text)) || (string.IsNullOrWhiteSpace(bunifuMetroTextbox10.Text)) || (string.IsNullOrWhiteSpace(bunifuMetroTextbox8.Text)))
                {
                    MessageBox.Show("Error : missing values");
                    return;
                }
            
            try
            {
                cd = new SqlCommand("insert into GARDE(fName,lName,Age,Gender,Adresse,bId,gCIN ) values('" + bunifuMetroTextbox6.Text + "','" + bunifuMetroTextbox5.Text + "' ," + bunifuMetroTextbox7.Text + ",'" + bunifuMetroTextbox9.Text + "','" + bunifuMetroTextbox10.Text + "',3,'" + bunifuMetroTextbox8.Text + "')", cn);
                cd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully !", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Some Errors occured" + ex.Message);
            }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            clearP();
            load2();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            try
            {
                
                DialogResult result = MessageBox.Show("do you want to Update this !", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    cd = new SqlCommand("UPDATE PRISONNIER SET fName = '" + bunifuMetroTextbox11.Text + "',lName = '" + bunifuMetroTextbox18.Text+ "', Age = "+bunifuMetroTextbox12.Text+ ", Gender = '"+bunifuMetroTextbox13.Text+"' , pHeight = "+ bunifuMetroTextbox15.Text+" , pWeight = "+ bunifuMetroTextbox16.Text+" , Adresse = '"+bunifuMetroTextbox17.Text+"' , pCIN= '"+bunifuMetroTextbox14.Text+"' , cId = "+ comboBox5.Text+" WHERE pId = "+ label3.Text, cn);
                     cd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully !", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearG();
                }

            }
            catch (SqlException ex)
            {
               MessageBox.Show("Some Errors occured" + ex.Message);
            }
            clearP();
            load2();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("do you want to insert this !", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if ((string.IsNullOrWhiteSpace(bunifuMetroTextbox11.Text)) || (string.IsNullOrWhiteSpace(bunifuMetroTextbox18.Text)) || (string.IsNullOrWhiteSpace(bunifuMetroTextbox12.Text)) || (string.IsNullOrWhiteSpace(bunifuMetroTextbox13.Text)) || (string.IsNullOrWhiteSpace(bunifuMetroTextbox15.Text)) || (string.IsNullOrWhiteSpace(bunifuMetroTextbox16.Text)) || (string.IsNullOrWhiteSpace(bunifuMetroTextbox17.Text)) || (string.IsNullOrWhiteSpace(bunifuMetroTextbox14.Text)) || (string.IsNullOrWhiteSpace(comboBox5.Text)))
                {
                    MessageBox.Show("Error : missing values");
                    return;
                }

                try
                {
                    cd = new SqlCommand("insert into PRISONNIER(fName,lName,Age,Gender,pHeight,pWeight,Adresse,pCIN,cId ) values('" + bunifuMetroTextbox11.Text + "','" + bunifuMetroTextbox18.Text + "' ," + bunifuMetroTextbox12.Text + ",'" + bunifuMetroTextbox13.Text + "','" + bunifuMetroTextbox15.Text + "','" + bunifuMetroTextbox16.Text + "','" + bunifuMetroTextbox17.Text + "','" + bunifuMetroTextbox14.Text + "','"+ comboBox5.Text+"')", cn);
                    cd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully !", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Some Errors occured" + ex.Message);
                }
            }
            clearP();
            load2();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            

            try
            {

                if (comboBox2.Text == "ID")
                {

                    cd = new SqlCommand("  select * from PRISONNIER where pId='" + bunifuMetroTextbox1.Text + "'", cn);

                }

                else if (comboBox2.Text == "CIN")
                {

                    cd = new SqlCommand("  select * from PRISONNIERE where pCIN='" + bunifuMetroTextbox1.Text + "'", cn);

                }
                else
                {

                    MessageBox.Show("Select a value");
                    return;
                }
                rd = cd.ExecuteReader();

                while (rd.Read())
                {
                    label3.Text = Convert.ToString(rd[0]);
                    bunifuMetroTextbox11.Text = Convert.ToString(rd[1]);
                    bunifuMetroTextbox18.Text = Convert.ToString(rd[2]);
                    bunifuMetroTextbox12.Text = Convert.ToString(rd[3]);
                    bunifuMetroTextbox13.Text = Convert.ToString(rd[4]);
                    bunifuMetroTextbox15.Text = Convert.ToString(rd[5]);
                    bunifuMetroTextbox16.Text = Convert.ToString(rd[6]);
                    bunifuMetroTextbox17.Text = Convert.ToString(rd[7]);
                    bunifuMetroTextbox14.Text = Convert.ToString(rd[8]);
                    comboBox5.Text= Convert.ToString(rd[9]);


                }

                rd.Close();
            }
            catch (SqlException ex)
            {
                bunifuCustomDataGrid1.Rows.Clear();
                MessageBox.Show("wrong Search Value !!", ex.Message);

            }
            load3();

        }

        private void bunifuMetroTextbox11_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            load();
        }

        private void bunifuFlatButton2_Click_2(object sender, EventArgs e)
        {
            try
            {
                cd = new SqlCommand("update DEMAND set Answer='" + comboBox4.Text + "' where dId=" + comboBox1.Text, cn);
                cd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully !", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Some Errors occured" + ex.Message);
            }
            load();
            bunifuCustomDataGrid3.Update();
            bunifuCustomDataGrid3.Refresh();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
