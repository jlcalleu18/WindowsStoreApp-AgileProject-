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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
           
            ProductPage home = new ProductPage();

            addUser(home);
   
        }
        ProductPage home = new ProductPage();
        public void addUser(UserControl userControl)
           
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public void button2_Click(object sender, EventArgs e)
        {
            
            addUser(home);
        }

        public void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
