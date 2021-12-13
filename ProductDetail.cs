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
    public partial class ProductDetail : Form
    {
        public ProductDetail()
        {
            InitializeComponent();
        }

        DataTable mydt = new DataTable();
        SqlConnection con;

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            ShoppingCart shop = new ShoppingCart();
          /* con = new SqlConnection();
            //Jorge Calle - Connection
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jorgecalle\\source\\repos\\Agile-Project\\DB-Product.mdf;Integrated Security=True";
            con.Open();

            //Build a command object to hold the SQL statement 
            SqlCommand mycommand = new SqlCommand();

            mycommand.Parameters.Add("@Id", SqlDbType.VarChar, 100);
            mycommand.Parameters["@Id"].Value = lblType;

            mycommand.CommandText = "SELECT * FROM Product WHERE Id >=  ";


            mycommand.Connection = con;

            //use dataadapter class to carry the command 
            //to the DBMS and return the results 

            SqlDataAdapter myadpter = new SqlDataAdapter();
            mydt = new DataTable();
            myadpter.SelectCommand = mycommand;


            //binding]

            shop.dataGridShop.AutoGenerateColumns = false;
            shop.dataGridShop.DataSource = mydt;
            myadpter.Fill(mydt);
*/




            
            shop.dataGridShop.Rows.Add(lblName.Text, lblPrice.Text);
            shop.ShowDialog();
        }
    }
}
