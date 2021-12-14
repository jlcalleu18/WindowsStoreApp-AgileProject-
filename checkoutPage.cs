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
    public partial class checkoutPage : Form
    {
        public checkoutPage()
        {
            InitializeComponent();
        }
        DataTable mydt = new DataTable();
        SqlConnection con;
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void load()
        {
   
        }
        private void button1_Click(object sender, EventArgs e)
        {

    
   
            System.Text.RegularExpressions.Regex rDate = new System.Text.RegularExpressions.Regex(@"^(0[1-9]|10|11|12)/20[0-9]{2}$");
            System.Text.RegularExpressions.Regex rCard = new System.Text.RegularExpressions.Regex(@"^4[0-9]{12}(?:[0-9]{3})?$");
            System.Text.RegularExpressions.Regex rZip = new System.Text.RegularExpressions.Regex(@"^[0-9]{5}(?:-[0-9]{4})?$");
            
            if (txtAddress.Text.Length > 0 && txtCardNumber.Text.Length > 0 && txtCity.Text.Length > 0 && txtCode.Text.Length > 0
                && txtMonth.Text.Length > 0 && txtSecurityCode.Text.Length > 0 && txtState.Text.Length > 0)
            {
                if (!rZip.IsMatch(txtCode.Text.Trim()))
                {
                    MessageBox.Show("Invalid Zip code");
                    txtCode.SelectAll();
                }
                else if (!rCard.IsMatch(txtCardNumber.Text.Trim()))
                {
                    MessageBox.Show("Invalid Card number");
                }
           
                else if (!rDate.IsMatch(txtMonth.Text.Trim()))
                {
                    MessageBox.Show("Invalid Month or Year - MM/YYYY");
                }
                else if (txtSecurityCode.Text.Length > 3)
                {
                    MessageBox.Show("Invalid Security Code");
                }
                else
                {
                    MessageBox.Show("Your purchase was successful");
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Fill the blanks");
            }
        }
    }
}
