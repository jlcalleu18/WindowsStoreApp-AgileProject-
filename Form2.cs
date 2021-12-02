using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Agile_Project
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
        }
        DataTable mydt = new DataTable();
        
        SqlConnection myconn;
        SqlTransaction mytrans;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //Establish a connection with the DBMS

            myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jorgecalle\\Documents\\CST4708\\Fall2021-CST4708.mdf;Integrated Security=True;Connect Timeout=30";
            myconn.Open();
            //MessageBox.Show("open DB");
            //Build a command object to hold the SQL statement 
            SqlCommand mycommand = new SqlCommand();



            if (txtFirstName.Text.Length > 0 && txtLastName.Text.Length > 0 && txtEmail.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                mycommand.Parameters.Add("@firstName", SqlDbType.VarChar, 100);
                mycommand.Parameters["@firstName"].Value = txtFirstName.Text;

                mycommand.Parameters.Add("@lastName", SqlDbType.VarChar, 100);
                mycommand.Parameters["@lastName"].Value = txtLastName.Text;

                mycommand.Parameters.Add("@email", SqlDbType.VarChar, 100);
                mycommand.Parameters["@email"].Value = txtEmail.Text;

                mycommand.Parameters.Add("@password", SqlDbType.VarChar, 100);
                mycommand.Parameters["@password"].Value = txtPassword.Text;

                //mycommand.CommandText = "SELECT * FROM Users WHERE lastname>@lastname AND age>@age";
            }


            mycommand.CommandText = "SELECT * FROM students WITH (READUNCOMMITTED)"; // WITH (READUNCOMMITTED) or  WITH (READPAST)-> readcommited


            mycommand.Connection = myconn;

            //use dataadapter class to carry the command 
            //to the DBMS and return the results 

            SqlDataAdapter myadpter = new SqlDataAdapter();
            mydt = new DataTable();
            myadpter.SelectCommand = mycommand;
            myadpter.Fill(mydt);

            //binding
       
        }
    }
}
