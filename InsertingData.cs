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
    public partial class InsertingData : Form
    {
        public InsertingData()
        {
            InitializeComponent();
        }
        DataTable mydt = new DataTable();

        SqlConnection con;
        private void btnAddData_Click(object sender, EventArgs e)
        {

            //Establish a connection with the DBMS

            con = new SqlConnection();
            //Jorge Calle - Connection
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jorgecalle\\source\\repos\\Agile-Project\\DB-Product.mdf;Integrated Security=True";


            SqlCommand mycommand = new SqlCommand();
            MemoryStream ms = new MemoryStream();
            imageBox.Image.Save(ms, imageBox.Image.RawFormat);
            byte[] img = ms.ToArray();

            if (txtProducts.Text.Length > 0 && txtBrand.Text.Length > 0 && txtModel.Text.Length > 0 && txtType.Text.Length > 0 && txtPrice.Text.Length > 0 && txtDescription.Text.Length > 0)
            {
               

                    mycommand.Connection = con;
                    mycommand.CommandText = "INSERT INTO Product (ProductName, Brand, Model, Type, Price, Description, Image) VALUES (@ProductName, @Brand, @Model, @Type, @Price, @Description, @Image)";
                    mycommand.Parameters.AddWithValue("@ProductName", txtProducts.Text);
                    mycommand.Parameters.AddWithValue("@Brand", txtBrand.Text);
                    mycommand.Parameters.AddWithValue("@Model", txtModel.Text);
                    mycommand.Parameters.AddWithValue("@Type", txtType.Text);
                    mycommand.Parameters.AddWithValue("@Price", txtPrice.Text);
                    mycommand.Parameters.AddWithValue("@Description", txtDescription.Text);
                    mycommand.Parameters.AddWithValue("@Image", img);

                    con.Open();
                    int i = mycommand.ExecuteNonQuery();
                    con.Close();

                    if (i != 0)
                    {
                        MessageBox.Show(i + " Data Saved");
                        txtProducts.Text = "";
                        txtBrand.Text = "";
                        txtModel.Text = "";
                        txtType.Text = "";
                        txtPrice.Text = "";
                        txtDescription.Text = "";
                    }
            }
            else
            {
                MessageBox.Show("fill the blanks");
            }


        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Filter = "Choose Image(*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";
            if(opFile.ShowDialog() == DialogResult.OK)
            {
                imageBox.Image = Image.FromFile(opFile.FileName);
            }
        }
    }
}
