using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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

   
        private void button1_Click(object sender, EventArgs e)
        {


            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            System.Text.RegularExpressions.Regex rDate = new System.Text.RegularExpressions.Regex(@"^(0[1-9]|10|11|12)/202[2-9]{1}$");
            System.Text.RegularExpressions.Regex rCard = new System.Text.RegularExpressions.Regex(@"^4[0-9]{12}(?:[0-9]{3})?$");
            System.Text.RegularExpressions.Regex rZip = new System.Text.RegularExpressions.Regex(@"^[0-9]{5}(?:-[0-9]{4})?$");
            
            if (txtAddress.Text.Length > 0 && txtCardNumber.Text.Length > 0 && txtCity.Text.Length > 0 && txtCode.Text.Length > 0
                && txtMonth.Text.Length > 0 && txtSecurityCode.Text.Length > 0 && txtState.Text.Length > 0
                 && txtEmail.Text.Length > 0 && txtFName.Text.Length > 0 && txtLastN.Text.Length > 0)
            {
                if (!rZip.IsMatch(txtCode.Text.Trim()))
                {
                    MessageBox.Show("Invalid Zip code");
                    txtCode.SelectAll();
                }
                else if (!rEmail.IsMatch(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Invalid Email");
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
                    OrderReviewPage order = new OrderReviewPage();
                    order.lblNameF.Text = this.txtFName.Text;
                    order.lblLastN.Text = this.txtLastN.Text;
                    order.lblEmail.Text = this.txtEmail.Text;
                    order.lblAddre.Text = this.txtAddress.Text;
                    order.lblSt.Text = this.txtState.Text;
                    order.lblCity.Text = this.txtCity.Text;
                    order.lblZip.Text = this.txtCode.Text;
                    order.lblCard.Text = this.txtCardNumber.Text;
                    order.lblExp.Text = this.txtMonth.Text;

                    order.lblSubTotal.Text = this.lblTotal.Text;

                    double value = Double.Parse(this.lblTotal.Text, NumberStyles.Currency);
                    double tax = value * 0.08875;
                    double total = value + tax;

                    order.lblTax.Text = "$" + String.Format("{0:0.00}", tax);
                    order.lblTotal.Text = "$" + String.Format("{0:0.00}", total);


                    this.Hide();
                    order.ShowDialog();

                }

            }
            else
            {
                MessageBox.Show("Fill the blanks");
            }
        }
    }
}
