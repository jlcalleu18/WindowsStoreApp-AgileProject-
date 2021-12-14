using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agile_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection myconn;
        string id, email, password, firstName, lastName;
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
    //this is from Shisir
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Establish a connection with the DBMS

            myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jorgecalle\\source\\repos\\Agile-Project\\data\\DB-Users.mdf;Integrated Security=True";
            //MessageBox.Show("open DB");
            //Build a command object to hold the SQL statement 
            SqlCommand mycommand = new SqlCommand();

            try
            {
                if (txtEmail.Text != "" && txtPassword.Text != "")
                {

                
    
                    myconn.Open();
                    mycommand.Connection = myconn;
                    mycommand.CommandText = "SELECT *FROM Users WHERE email=@email and password=@password";
                    mycommand.Parameters.AddWithValue("@email", txtEmail.Text);
                    mycommand.Parameters.AddWithValue("@password", txtPassword.Text);
                    
                    SqlDataReader reader;
                    reader = mycommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            id = reader["id"].ToString();
                            email = reader["email"].ToString();
                            password = reader["password"].ToString();
                            firstName = reader["firstName"].ToString();
                            lastName = reader["lastName"].ToString();
                         
                        }
                        MessageBox.Show("Data found your name is " + firstName + " " + lastName);
                        txtEmail.Text = "";
                        txtPassword.Text="";
                    }
                    else
                    {
                        MessageBox.Show("Data not found", "Information");
                        txtPassword.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is empty", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
