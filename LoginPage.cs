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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        SqlConnection myconn;
        string id, email, password, firstName, lastName;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterPage register = new RegisterPage();
            this.Hide();
            register.ShowDialog();
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
                     //next page   
                        ProductPage pro = new ProductPage();
                        HomePage home = new HomePage();
                        pro.lblFName.Text = firstName;
                        pro.lblLName.Text = lastName;
                        pro.lblEmail.Text = id;

                        this.Hide();
                        pro.ShowDialog();
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

    }
}
