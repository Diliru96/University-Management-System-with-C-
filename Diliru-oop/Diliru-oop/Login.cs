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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            MySqlConnection cn = new
            MySqlConnection
            ("datasource=localhost;port=3306;database='stafford';username=root;password=");

            MySqlDataAdapter adapter;

            DataTable table = new DataTable();

            adapter = new MySqlDataAdapter("SELECT `username`, `password` FROM `students` WHERE `username` = '" + txtUserName.Text + "' AND `password` = '" + txtPasswod.Text + "'", cn);
            adapter.Fill(table);

           



           if (txtPasswod.Text == "" )
            {
                string message = "Please enter a Password";
                string title = "Error!";
                MessageBox.Show(message, title);
            }

            else if (txtPasswod.Text == "" )
            {
                string message = "Please enter a Password a User Name";
                string title = "Error!";
                MessageBox.Show(message, title);
            }

            else if (txtPasswod.Text == "1234" && txtUserName.Text == "admin")
            {
                this.Visible = false;
                Registar_home Registar_home = new Registar_home();
                Registar_home.Show();
            }

            else if (table.Rows.Count == 1)
            {
                string message = "Welcome to Stafford";
                string title = "Student Identified";
                MessageBox.Show(message, title);

                this.Visible = false;
                Student_Home Student_Home = new Student_Home();
                Student_Home.Show();

            }


            else 
            {
               
                adapter = new MySqlDataAdapter("SELECT `username`, `password` FROM `professors` WHERE `username` = '" + txtUserName.Text + "' AND `password` = '" + txtPasswod.Text + "'", cn);
                adapter.Fill(table);


                if(table.Rows.Count == 1)

               {
                    string message = "Welcome to Stafford";
                    string title = "Professor Identified";
                    MessageBox.Show(message, title);


                    this.Visible = false;
                    professor_home Professor_Home = new professor_home();
                    Professor_Home.Show();

                }


                else
                {

                    string message = "User Password or Username is incorrect";
                    string title = "Error!";
                    MessageBox.Show(message, title);

                }

            }


            
        }
    }
}
