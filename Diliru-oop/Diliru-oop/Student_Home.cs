using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Diliru_oop
{
    public partial class Student_Home : Form
    {

        int fee01, fee02 , fee03 , fee04;

        int c1, c2, c3, c4;
        int c11, c22, c33, c44;

        public Student_Home()
        {
            InitializeComponent();


            try
            {
                MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");

                string selectQuery = "SELECT * FROM stafford.courses WHERE studentCount < 10";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString("courseName"));
                    comboBox2.Items.Add(reader.GetString("courseName"));
                    comboBox3.Items.Add(reader.GetString("courseName"));
                    comboBox4.Items.Add(reader.GetString("courseName"));
                    comboBox5.Items.Add(reader.GetString("courseName"));
                    comboBox6.Items.Add(reader.GetString("courseName"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnCourseCatalog_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            studentCourseCtalog studentCourseCtalog = new studentCourseCtalog();
            studentCourseCtalog.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login Login = new Login();
            Login.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)

        {
            MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");

            string selectQuery = "SELECT * FROM stafford.courses WHERE courseName='" + this.comboBox1.Text + "';";
            connection.Open();
            MySqlCommand command = new MySqlCommand(selectQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();
            
            if (reader.Read())
            {
                 fee01 = Convert.ToInt32(reader.GetString("fee"));
            }
            
            connection.Close();

            string selectQuery2 = "SELECT * FROM stafford.courses WHERE courseName='" + this.comboBox2.Text + "';";
            connection.Open();
            MySqlCommand command2 = new MySqlCommand(selectQuery2, connection);
            MySqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                 fee02 = Convert.ToInt32(reader2.GetString("fee"));
            }
            connection.Close();

            string selectQuery3 = "SELECT * FROM stafford.courses WHERE courseName='" + this.comboBox3.Text + "';";
            connection.Open();
            MySqlCommand command3 = new MySqlCommand(selectQuery3, connection);
            MySqlDataReader reader3 = command3.ExecuteReader();
            if (reader3.Read())
            {
                 fee03 = Convert.ToInt32(reader3.GetString("fee"));
            }
            connection.Close();

            string selectQuery4 = "SELECT * FROM stafford.courses WHERE courseName='" + this.comboBox4.Text + "';";
           connection.Open();
            MySqlCommand command4 = new MySqlCommand(selectQuery4, connection);
            MySqlDataReader reader4 = command4.ExecuteReader();
            if (reader4.Read())
            {
                 fee04 = Convert.ToInt32(reader4.GetString("fee"));
            }
            connection.Close();

            int dueFee = fee01 + fee02 + fee03 + fee04;


            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "UPDATE stafford.students SET course01='" + this.comboBox1.Text + "',course02='" + this.comboBox2.Text + "',course03='" + 
                    this.comboBox3.Text + "',course04='" + this.comboBox4.Text + "',alternativeCourse01='" + this.comboBox5.Text + "',alternativeCourse02='" + 
                    this.comboBox6.Text + "',dueFee='" + dueFee.ToString() + "' where username='" + this.txtStuName.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            string selectQuery5 = "SELECT * FROM stafford.courses WHERE courseName='" + this.comboBox1.Text + "';";
            connection.Open();
            MySqlCommand command5 = new MySqlCommand(selectQuery5, connection);
            MySqlDataReader reader5 = command5.ExecuteReader();
            if (reader5.Read())
            {
                c1 = Convert.ToInt32(reader5.GetString("studentCount"));
            }
            connection.Close();

            string selectQuery6 = "SELECT * FROM stafford.courses WHERE courseName='" + this.comboBox2.Text + "';";
            connection.Open();
            MySqlCommand command6 = new MySqlCommand(selectQuery6, connection);
            MySqlDataReader reader6 = command6.ExecuteReader();
            if (reader6.Read())
            {
                c2 = Convert.ToInt32(reader6.GetString("studentCount"));
            }
            connection.Close();

            string selectQuery7 = "SELECT * FROM stafford.courses WHERE courseName='" + this.comboBox3.Text + "';";
            connection.Open();
            MySqlCommand command7 = new MySqlCommand(selectQuery7, connection);
            MySqlDataReader reader7 = command7.ExecuteReader();
            if (reader7.Read())
            {
                c3 = Convert.ToInt32(reader7.GetString("studentCount"));
            }
            connection.Close();

            string selectQuery8 = "SELECT * FROM stafford.courses WHERE courseName='" + this.comboBox4.Text + "';";
            connection.Open();
            MySqlCommand command8 = new MySqlCommand(selectQuery8, connection);
            MySqlDataReader reader8 = command8.ExecuteReader();
            if (reader8.Read())
            {
                c4 = Convert.ToInt32(reader8.GetString("studentCount"));
            }
            connection.Close();



            c11 = c1 + 1;
            c22 = c2 + 1;
            c33 = c3 + 1;
            c44 = c4 + 1;


            
            string Query9 = "UPDATE stafford.courses SET studentCount='" + c11.ToString() +  "' where courseName='" + this.comboBox1.Text + "';";
            connection.Open();
            MySqlCommand Command9 = new MySqlCommand(Query9, connection);
            MySqlDataReader reader9;
            reader9 = Command9.ExecuteReader();
            MessageBox.Show("Data Updated");
            while (reader9.Read())
            {
            }
            connection.Close();


            string Query10 = "UPDATE stafford.courses SET studentCount='" + c22.ToString() + "' where courseName='" + this.comboBox2.Text + "';";
            connection.Open();
            MySqlCommand Command10 = new MySqlCommand(Query10, connection);
            MySqlDataReader reader10;
            reader10 = Command10.ExecuteReader();
            MessageBox.Show("Data Updated");
            while (reader10.Read())
            {
            }
            connection.Close();

            string Query11 = "UPDATE stafford.courses SET studentCount='" + c33.ToString() + "' where courseName='" + this.comboBox3.Text + "';";
            connection.Open();
            MySqlCommand Command11 = new MySqlCommand(Query11, connection);
            MySqlDataReader reader11;
            reader11 = Command11.ExecuteReader();
            MessageBox.Show("Data Updated");
            while (reader11.Read())
            {
            }
            connection.Close();


            string Query12 = "UPDATE stafford.courses SET studentCount='" + c44.ToString() + "' where courseName='" + this.comboBox4.Text + "';";
            connection.Open();
            MySqlCommand Command12 = new MySqlCommand(Query12, connection);
            MySqlDataReader reader12;
            reader12 = Command12.ExecuteReader();
            MessageBox.Show("Data Updated");
            while (reader12.Read())
            {
            }
            connection.Close();

        }
    }
}
