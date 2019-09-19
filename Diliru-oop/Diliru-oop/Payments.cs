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
using System.IO;

namespace Diliru_oop
{
    public partial class Payments : Form
    {
        int fee1, feeAfter, paidfee;

        public Payments()
        {
            InitializeComponent();

            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                //Display query  
                string Query = "select * from stafford.students WHERE dueFee IS NOT NULL;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Registar_home Registar_home = new Registar_home();
            Registar_home.Show();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                //Display query  
                string Query = "select * from stafford.students where username='" + this.txtSearchStudent.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView2.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");

            string Query1 = "UPDATE stafford.students SET paidFee='" + this.txtpayments.Text + "' where username='" + this.txtSearchStudent.Text + "';";
            connection.Open();
            MySqlCommand Command1 = new MySqlCommand(Query1, connection);
            MySqlDataReader reader1;
            reader1 = Command1.ExecuteReader();
            MessageBox.Show("Data Updated");
            while (reader1.Read())
            {
            }
            connection.Close();



            string selectQuery = "SELECT * FROM stafford.students WHERE username='" + this.txtSearchStudent.Text + "';";
            connection.Open();
            MySqlCommand command = new MySqlCommand(selectQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                fee1 = Convert.ToInt32(reader.GetString("dueFee"));
            }

            connection.Close();


            paidfee = Convert.ToInt32(txtpayments.Text);

            feeAfter = fee1 - paidfee;

            string Query2 = "UPDATE stafford.students SET dueFee='" + feeAfter.ToString() + "' where username='" + this.txtSearchStudent.Text + "';";
            connection.Open();
            MySqlCommand Command2 = new MySqlCommand(Query2, connection);
            MySqlDataReader reader2;
            reader2 = Command2.ExecuteReader();
            MessageBox.Show("Data Updated");
            while (reader2.Read())
            {
            }
            connection.Close();



            FileStream fs1 = new FileStream("C:\\Users\\Diliru\\Desktop\\oop final\\'" + this.txtSearchStudent.Text , FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs1);
            writer.Write("Student Name "+ this.txtSearchStudent.Text +" Payments "+ this.txtpayments.Text );
            writer.Close();


        }
    }
}
