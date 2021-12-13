using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
//using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Agile_Project
{
    public partial class ProductPage : Form
    {
        public ProductPage()
        {
            InitializeComponent();
            loadData();
           
        }


        DataTable mydt = new DataTable();

        SqlConnection con;
        public void loadData()
        {
            con = new SqlConnection();
            //Jorge Calle - Connection
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jorgecalle\\source\\repos\\Agile-Project\\DB-Product.mdf;Integrated Security=True";
            con.Open();
        
            //Build a command object to hold the SQL statement 
            SqlCommand mycommand = new SqlCommand();

            mycommand.CommandText = "SELECT ProductName, Price, Image FROM Product ";


            mycommand.Connection = con;

            //use dataadapter class to carry the command 
            //to the DBMS and return the results 

            SqlDataAdapter myadpter = new SqlDataAdapter();
            mydt = new DataTable();
            myadpter.SelectCommand = mycommand;


            //binding]
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = mydt;
            myadpter.Fill(mydt);


        }
/*        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }*/

    }
 
}
