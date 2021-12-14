using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridShop.Rows.Clear();
            dataGridShop.Refresh();
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
                this.Hide();
                checkoutPage check = new checkoutPage();
                check.picCheckout.Image = ((Image)dataGridShop.CurrentRow.Cells[0].Value);
                check.lblName.Text = this.dataGridShop.CurrentRow.Cells[1].Value.ToString();
                check.lblPriceCheck.Text = this.dataGridShop.CurrentRow.Cells[2].Value.ToString();
                check.lblTotal.Text = this.dataGridShop.CurrentRow.Cells[2].Value.ToString();

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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
