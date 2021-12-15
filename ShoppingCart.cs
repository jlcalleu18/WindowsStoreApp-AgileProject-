using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agile_Project
{
    public partial class ShoppingCart : Form
    {
        public ShoppingCart()
        {
            InitializeComponent();
            HomePage pro = new HomePage();

        }
        SqlConnection myconn;
        string id, email, password, firstName, lastName;
        checkoutPage check = new checkoutPage();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridShop.Rows.Clear();
            dataGridShop.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridShop.Rows.Count == 0)
            {
                MessageBox.Show("The shopping cart is empty");
            }
            else
            {
                
                
                check.picCheckout.Image = ((Image)dataGridShop.CurrentRow.Cells[0].Value);
                check.lblName.Text = this.dataGridShop.CurrentRow.Cells[1].Value.ToString();
                check.lblPriceCheck.Text = this.dataGridShop.CurrentRow.Cells[2].Value.ToString();
                check.lblTotal.Text = this.dataGridShop.CurrentRow.Cells[2].Value.ToString();

                this.Hide();
                check.Show();
            }
            
 
        }
        private static Image ConvertByteArrayToImage(byte[] byteArrayToConvert)
        {
            Image ret;

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(byteArrayToConvert, 0, byteArrayToConvert.Length);
                    ret = new Bitmap(ms);
                }
            }
            catch (Exception) { throw; }

            return ret;
        }
        private void load()
        {
            //Establish a connection with the DBMS

             myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jorgecalle\\source\\repos\\Agile-Project\\data\\DB-Users.mdf;Integrated Security=True";
            //MessageBox.Show("open DB");
            //Build a command object to hold the SQL statement 
            SqlCommand mycommand = new SqlCommand();

            try
            {
               
                    myconn.Open();
                    mycommand.Connection = myconn;
                    mycommand.CommandText = "SELECT *FROM Users WHERE email=@email and password=@password";
       /*             mycommand.Parameters.AddWithValue("@email", txtEmail.Text);
                    mycommand.Parameters.AddWithValue("@password", txtPassword.Text);*/

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
                        HomePage pro = new HomePage();
                        pro.lblFName.Text = firstName;
                        pro.lblLName.Text = lastName;
                    

                        this.Hide();
                        pro.ShowDialog();
                   
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
