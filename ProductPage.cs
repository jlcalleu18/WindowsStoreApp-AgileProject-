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
    public partial class ProductPage : Form
    {
        public ProductPage()
        {
            InitializeComponent();
           
            HomePage home = new HomePage();
            home.lblID.Text = this.lblEmail.Text;
            addUser(home);
            


        }
        public void addUser(UserControl userControl)
           
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            addUser(home);
        }

        public void button1_Click(object sender, EventArgs e)
        {
           
        }  
    }
}
